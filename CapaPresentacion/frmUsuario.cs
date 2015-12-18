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
    public partial class frmUsuario : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        crypt encriptar = new crypt();

        public frmUsuario()
        {
            InitializeComponent();
            LlenarComboPresentacion();
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
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtId.Text = string.Empty;
            this.txtUsuario.Text = string.Empty;
            this.txtClave.Text = string.Empty;
        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtNombre.ReadOnly = !valor;
            this.txtApellido.ReadOnly = !valor;
            this.txtId.ReadOnly = !valor;
            this.txtUsuario.ReadOnly = !valor;
            this.txtClave.ReadOnly = !valor;
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
                this.txtDepartamento.Visible = false;
                this.cbDepartamento.Visible = true;
            }
            else
            {
                this.Habilitar(false);
                this.tsNuevo.Enabled = true;
                this.tsEditar.Enabled = true;
                this.tsCancelar.Enabled = false;
                this.tsGuardar.Enabled = false;
                this.txtDepartamento.Visible = true;
                this.cbDepartamento.Visible = false;
            }
        }

        //Método Mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = NUsuario.Mostrar();
            this.OcultarColumnas();
        }

        //Método para ocultar columnas
        private void OcultarColumnas()
        {
            this.dataListado.Columns[2].Visible = false;
            this.dataListado.Columns[5].Visible = false;
        }

        //Método LlenarComboPresentación
        private void LlenarComboPresentacion()
        {
            cbDepartamento.DataSource = NDepartamento.Mostrar();
            cbDepartamento.ValueMember = "iddepartamento";
            cbDepartamento.DisplayMember = "nombre";
        }

        //Método BuscarNombre
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NUsuario.BuscarNombre(this.txtBuscar.Text);
        }

        //Método BuscarApellido
        private void BuscarApellido()
        {
            this.dataListado.DataSource = NUsuario.BuscarApellido(this.txtBuscar.Text);
        }

        //Método cambiar nombre columnas
        private void NombreColumnas()
        {
            this.dataListado.Columns[0].HeaderText = "Código";
            this.dataListado.Columns[1].HeaderText = "Usuario";
            this.dataListado.Columns[2].HeaderText = "Password";
            this.dataListado.Columns[3].HeaderText = "Nombre";
            this.dataListado.Columns[4].HeaderText = "Apellido";
            this.dataListado.Columns[5].HeaderText = "IdDepartamento";
            this.dataListado.Columns[6].HeaderText = "Departamento";
            this.dataListado.Columns[7].HeaderText = "Activo";
            this.dataListado.Columns[0].Width = 60;
            this.dataListado.Columns[1].Width = 100;
            this.dataListado.Columns[2].Width = 100;
            this.dataListado.Columns[3].Width = 100;
            this.dataListado.Columns[4].Width = 100;
            this.dataListado.Columns[5].Width = 100;
            this.dataListado.Columns[6].Width = 150;
            this.dataListado.Columns[6].Width = 60;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
            this.NombreColumnas();
            this.txtId.Enabled = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataListado.CurrentRow != null)
            {
                this.txtId.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["id"].Value);
                this.txtUsuario.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["usuario"].Value);
                this.txtClave.Text = encriptar.DecryptKey(Convert.ToString(this.dataListado.CurrentRow.Cells["password"].Value));
                this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
                this.txtApellido.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["apellido"].Value);
                this.txtDepartamento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombreDepartamento"].Value);

                if (Convert.ToInt32(this.dataListado.CurrentRow.Cells["activo"].Value) == 1)
                {
                    this.checkBoxActivo.Checked = true;
                }
                else
                {
                    this.checkBoxActivo.Checked = false;
                }
            }            
        }

        private void dataListado_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataListado.CurrentRow != null)
            {
                this.txtId.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["id"].Value);
                this.txtUsuario.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["usuario"].Value);
                this.txtClave.Text = encriptar.DecryptKey(Convert.ToString(this.dataListado.CurrentRow.Cells["password"].Value));
                this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
                this.txtApellido.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["apellido"].Value);
                this.txtDepartamento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombreDepartamento"].Value);

                if (Convert.ToInt32(this.dataListado.CurrentRow.Cells["activo"].Value) == 1)
                {
                    this.checkBoxActivo.Checked = true;
                }
                else
                {
                    this.checkBoxActivo.Checked = false;
                }
            }
            
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtNombre.Text == string.Empty || this.txtApellido.Text == string.Empty || this.txtUsuario.Text == string.Empty || this.txtClave.Text == string.Empty || this.cbDepartamento.SelectedIndex == null)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtNombre, "Ingrese el nombre del trabajador");
                    errorIcono.SetError(txtApellido, "Ingrese el apellido del trabajador");
                    errorIcono.SetError(txtUsuario, "Ingrese el usuario del trabajador");
                    errorIcono.SetError(txtClave, "Ingrese la clave del trabajador");
                    errorIcono.SetError(cbDepartamento, "Ingrese el Departamento asignado al trabajador");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NUsuario.Insertar(this.txtUsuario.Text.Trim(),
                            encriptar.EncryptKey(this.txtClave.Text.Trim()), this.txtNombre.Text.Trim().ToUpper(),
                            this.txtApellido.Text.Trim().ToUpper(),
                            Convert.ToInt32(cbDepartamento.SelectedValue), checkBoxActivo.Checked);
                    }
                    else
                    {
                        rpta = NUsuario.Editar(Convert.ToInt32(this.txtId.Text), this.txtUsuario.Text.Trim(),
                            encriptar.EncryptKey(this.txtClave.Text.Trim()), this.txtNombre.Text.Trim().ToUpper(),
                            this.txtApellido.Text.Trim().ToUpper(),
                            Convert.ToInt32(cbDepartamento.SelectedValue), checkBoxActivo.Checked);
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

        private void tsEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtId.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
                this.dataListado.Enabled = false;
                this.txtBuscar.Enabled = false;
                this.cbDepartamento.SelectedItem = this.txtDepartamento.Text;
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a modificar");
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

        private void tsCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
            this.dataListado.Enabled = true;
            this.txtBuscar.Enabled = true;
        }
    }
}
