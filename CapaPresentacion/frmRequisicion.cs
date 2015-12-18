using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmRequisicion : Form
    {
        private bool IsNuevo = true;
        private bool IsEditar = false;
        public string IdTrabajador = "";
        public string Apellidos = "";
        public string Nombres = "";
        public string Acceso = "";
        public string Activo = "";

        //Métodos para pasar datos desde la frmVistaCategoria_Articulo
        private static frmRequisicion _Instancia;

        public static frmRequisicion GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmRequisicion();
            }
            return _Instancia;
        }

        public void agregarArticulo(string cantidad, string unidad, string descripcion, string justificacion)
        {
            this.dataListado.Rows.Add(cantidad, unidad, descripcion, justificacion);
        }

        public frmRequisicion()
        {            
            InitializeComponent();
        }

        //Mostrar Mensaje de Confirmación
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Temisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Temisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los controlos del formulario
        private void Limpiar()
        {
            this.cbCaracter.SelectedItem = null;
            this.txtOrdenTrabajo.Text = "N/A";
            this.dataListado.Rows.Clear();
        }

        //Método Mostrar
        private void Mostrar()
        {
            this.dataGridView1.DataSource = NRequisicion.ObtenerId();
            string cadena = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
            
            if (cadena.Equals("1") && NRequisicion.Mostrar().Rows.Count < 1)
            {
                this.txtNumRequisicion.Text = "1";
            }
            else
            {                
                int id = Convert.ToInt32(cadena);
                this.txtNumRequisicion.Text = Convert.ToString(id + 1);
            }            
        }

        //Mostrar los controles del formulario
        private void MostrarControles(bool valor)
        {            
            this.dataListado.Visible = valor;
            this.groupBox1.Visible = valor;
            this.dataGridView1.Visible = valor;
        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.dataListado.Enabled = valor;
            this.groupBox1.Enabled = valor;
            this.dataGridView1.Visible = valor;
        }

        private void frmRequisicion_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.txtFecha.Text = DateTime.Now.ToString();
            this.Mostrar();
            this.txtId.Text = IdTrabajador;
            this.txtSolicitante.Text = Nombres + " " + Apellidos;
            Habilitar(false);
            MostrarControles(false);
            this.tsImprimir.Visible = false;
            this.tsStatus.Visible = false;
        }

        private void dataListado_KeyDown(object sender, KeyEventArgs e)
        {
            DialogResult Opcion;

            if (e.KeyCode == Keys.Delete)
            {
                Opcion = MessageBox.Show("Realmente desea eliminar el registro", "Temisa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    try
                    {
                        int selectedIndex = dataListado.CurrentCell.RowIndex;
                        if (selectedIndex > -1)
                        {
                            dataListado.Rows.RemoveAt(selectedIndex);
                            dataListado.Refresh();
                        }
                    }
                    catch (InvalidOperationException)
                    {
                        MessageBox.Show("Seleccione el item a eliminar");
                    }
                }
            }
        }

        private void dataListado_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmRequisicionAgregar form = new frmRequisicionAgregar();
            form.ShowDialog();
        }

        private void TsGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (dataListado.Rows.Count == 0)
                {
                    MensajeError("No ha agregado ningún item, por favor insete un producto");
                }
                else if (this.cbCaracter.SelectedItem == null)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(cbCaracter, "Selecione el carácter de la requisición");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        this.Mostrar();
                        rpta = NRequisicion.Insertar(int.Parse(this.txtId.Text), this.cbCaracter.Text, DateTime.Now, this.txtOrdenTrabajo.Text);
                        
                        foreach (DataGridViewRow row in dataListado.Rows)
                        {
                            if (row.Cells["Cantidad"].Value != null)
                            {
                                rpta = NDetalleRequisicion.Insertar(int.Parse(this.txtNumRequisicion.Text), decimal.Parse(row.Cells["Cantidad"].Value.ToString()), "N/A", Convert.ToString(row.Cells["Descripcion"].Value), Convert.ToString(row.Cells["Unidad"].Value), "POR REVISAR", "POR REVISAR", "POR REVISAR", DateTime.Now, DateTime.Now, DateTime.Now, 1, 1, 1, Convert.ToString(row.Cells["Justificacion"].Value));
                            }                            
                        }                        
                    }
                    else
                    {
                        //rpta = NDepartamento.Editar(Convert.ToInt32(this.txtCodigo.Text),
                        //    this.txtNombre.Text.Trim().ToUpper(),
                        //    this.txtDescripcion.Text.Trim().ToUpper());
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOK("Se insertó de forma correcta el registro");
                            this.Habilitar(false);
                            this.Limpiar();
                            this.TsGuardar.Enabled = false;
                        }
                        else
                        {
                            this.MensajeOK("Se actualizó de forma correcta el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    this.IsNuevo = true;
                    this.IsEditar = false;                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            MostrarControles(true);
            Mostrar();
            Limpiar();
            this.TsGuardar.Enabled = true;
        }

        private void frmRequisicion_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
