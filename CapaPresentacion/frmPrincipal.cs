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
    public partial class frmPrincipal : Form
    {
        private int childFormNumber = 0;
        public string IdTrabajador = "";
        public string Apellidos = "";
        public string Nombres = "";
        public string Acceso = "";
        public string Activo = "";
        private bool IsSalir = true;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Control de usuarios
        private void GestionUsuarios()
        {
            if (Acceso.Equals("1")) //Produccion
            {
                this.mnuRequisicion.Enabled = true;
                this.mnuMantenimiento.Enabled = false;
            }
            else if (Acceso.Equals("2")) //Almacen
            {
                this.mnuRequisicion.Enabled = true;
                this.mnuMantenimiento.Enabled = false;
            }
            else if (Acceso.Equals("3")) //Compra
            {
                this.mnuRequisicion.Enabled = true;
                this.mnuMantenimiento.Enabled = false;
            }
            else //Direccion
            {
                this.mnuRequisicion.Enabled = true;
                this.mnuMantenimiento.Enabled = true;
            }

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.IsSalir = true;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRequisicion frm = frmRequisicion.GetInstancia();
            frm.MdiParent = this;
            frm.IdTrabajador = IdTrabajador;
            frm.Nombres = Nombres;
            frm.Apellidos = Apellidos;
            frm.Show();
        }

        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartamento frm = new frmDepartamento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollo iBOT\nIturbide 611 Col. Villaseñor\nGuadalajara Jalisco México.\nHEGM830327483\nOficina GDL. +52 33 36362911\nOficina CCS. +58 424 1634012", "Temisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaRequisicion frm = new frmConsultaRequisicion();
            frm.MdiParent = this;
            frm.IdTrabajador = IdTrabajador;
            frm.Nombres = Nombres;
            frm.Apellidos = Apellidos;
            frm.Acceso = Acceso;
            frm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            GestionUsuarios();
        }

        private void cerrarSecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = frmLogin.GetInstancia();
            frm.Show();                
            this.Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (IsSalir)
            {
                // Confirm user wants to close
                switch (MessageBox.Show(this, "¿Esta seguro que quiere salir?", "TEMISA", MessageBoxButtons.YesNo))
                {
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        IsSalir = false;
                        frmLogin frm = frmLogin.GetInstancia();                        
                        frm.salir();
                        break;
                }                  
            }
        }
    }
}
