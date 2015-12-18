using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmRequisicionAgregar : Form
    {
        validar validacion = new validar();

        public frmRequisicionAgregar()
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
            this.txtCantidad.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.cbUnidad.SelectedItem = null;
            this.txtJustificacion.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtCantidad.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtJustificacion.Text = string.Empty;
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtCantidad.Text == string.Empty || this.txtDescripcion.Text == string.Empty || this.cbUnidad.SelectedItem == null || this.txtJustificacion.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
            } 
            if (this.txtCantidad.Text == string.Empty)
            {
                errorIcono.SetError(this.txtCantidad, "Ingrese la cantidad");
            } 
            else if (this.txtDescripcion.Text == string.Empty)
            {
                errorIcono.SetError(this.txtDescripcion, "Ingrese la descripción");                
            }
            else if (this.cbUnidad.SelectedItem == null)
            {
                errorIcono.SetError(this.cbUnidad, "Seleccione una unidad");
            }
            else if (this.txtJustificacion.Text == string.Empty)
            {
                errorIcono.SetError(this.txtJustificacion, "Ingrese la justificación");
            }
            else
            {
                frmRequisicion form = frmRequisicion.GetInstancia();
                string cantidad, unidad, descripcion, justificacion;
                cantidad = this.txtCantidad.Text;
                unidad = this.cbUnidad.Text;
                descripcion = this.txtDescripcion.Text;
                justificacion = this.txtJustificacion.Text;
                form.agregarArticulo(cantidad.Trim().ToUpper(), unidad, descripcion.Trim().ToUpper(), justificacion.Trim().ToUpper());
                errorIcono.Clear();

                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea agregar otro registro?", "Temisa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    this.Limpiar();
                    this.txtCantidad.Focus();
                }
                else
                {
                    this.Hide();
                }
            }            
        }

        private void frmRequisicionAgregar_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 552;
            this.txtCantidad.Focus();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }
    }
}
