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
    public partial class frmDepartamento : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        //Métodos para pasar datos desde la frmVistaCategoria_Articulo
        private static frmDepartamento _Instancia;

        public static frmDepartamento GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmDepartamento();
            }
            return _Instancia;
        }

        public frmDepartamento()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese el nombre del Departamento");            
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
            this.txtCodigo.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtCodigo.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
        }

        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.tsNuevo.Enabled = false;
                this.tsEditar.Enabled = false;
                this.tsCancelar.Enabled = true;
                this.tsGuardar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.tsNuevo.Enabled = true;
                this.tsEditar.Enabled = true;
                this.tsCancelar.Enabled = false;
                this.tsGuardar.Enabled = false;
            }
        }        

        //Método Mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = NDepartamento.Mostrar();
            this.txtCodigo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["iddepartamento"].Value);
            this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["descripcion"].Value);
        }

        //Método BuscarNombre
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NDepartamento.BuscarNombre(this.txtBuscar.Text);
        }

        //Método cambiar nombre columnas
        private void NombreColumnas()
        {
            this.dataListado.Columns[0].HeaderText = "Código";
            this.dataListado.Columns[1].HeaderText = "Nombre";
            this.dataListado.Columns[2].HeaderText = "Descripción";
            this.dataListado.Columns[0].Width = 60;
            this.dataListado.Columns[1].Width = 100;
            this.dataListado.Columns[2].Width = 200;
        }

        private void frmDepartamento_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
            this.NombreColumnas();
            this.txtCodigo.Enabled = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }
        
        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            if (this.dataListado.CurrentRow != null)
            {
                this.txtCodigo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["iddepartamento"].Value);
                this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
                this.txtDescripcion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["descripcion"].Value);
            }            
        }

        private void dataListado_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataListado.CurrentRow != null)
            {
                this.txtCodigo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["iddepartamento"].Value);
                this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
                this.txtDescripcion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["descripcion"].Value);
            }            
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtNombre.Focus();
            this.dataListado.Enabled = false;
            this.txtBuscar.Enabled = false;
        }

        private void TsGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtNombre.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtNombre, "Ingrese un valor");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NDepartamento.Insertar(this.txtNombre.Text.Trim().ToUpper(),
                            this.txtDescripcion.Text.Trim().ToUpper());
                    }
                    else
                    {
                        rpta = NDepartamento.Editar(Convert.ToInt32(this.txtCodigo.Text),
                            this.txtNombre.Text.Trim().ToUpper(),
                            this.txtDescripcion.Text.Trim().ToUpper());
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOK("Se insertó de forma correcta el registro");
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

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                    this.dataListado.Enabled = true;
                    this.txtBuscar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
            this.dataListado.Enabled = true;
            this.txtBuscar.Enabled = true;
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtCodigo.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
                this.dataListado.Enabled = false;
                this.txtBuscar.Enabled = false;
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a modificar");
            }
        }

    }
}
