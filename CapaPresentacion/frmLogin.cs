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
    public partial class frmLogin : Form
    {
        crypt encriptar = new crypt();
        private static frmLogin _Instancia;

        public static frmLogin GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmLogin();
            }
            return _Instancia;
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        //Método Salir
        public void salir()
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable Datos = NUsuario.Login(this.txtUsuario.Text, encriptar.EncryptKey(this.txtPassword.Text));

            if (this.txtUsuario.Text == string.Empty || this.txtPassword.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                if (this.txtUsuario.Text == string.Empty)
                {
                    errorIcono.SetError(txtUsuario, "Ingrese el usuario");
                }
                if (this.txtPassword.Text == string.Empty)
                {
                    errorIcono.SetError(txtPassword, "Ingrese la clave");
                }
            }
            else
            {
                //Validacion si existe el usuario
                if (Datos.Rows.Count == 0 || Datos.Rows[0][6].ToString().Equals("False"))
                {
                    MessageBox.Show("No tiene acceso al sistema, compruebe su usuario y clave", "Sistema de Requisición", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frmPrincipal frm = new frmPrincipal();
                    frm.IdTrabajador = Datos.Rows[0][0].ToString();
                    frm.Apellidos = Datos.Rows[0][4].ToString();
                    frm.Nombres = Datos.Rows[0][3].ToString();
                    frm.Acceso = Datos.Rows[0][5].ToString();
                    frm.Activo = Datos.Rows[0][6].ToString();
                    frm.Show();
                    this.Hide();
                }
            }            
        }
    }
}
