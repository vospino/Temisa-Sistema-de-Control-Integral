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
    public partial class frmConsultaRequisicion : Form
    {
        public string IdTrabajador = "";
        public string Apellidos = "";
        public string Nombres = "";
        public string Acceso = "";

        public frmConsultaRequisicion()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnGuardarAlmacen, "Guardar Status de Almacen");
            this.ttMensaje.SetToolTip(this.btnGuardarCompra, "Guardar Status de Compra");
            this.ttMensaje.SetToolTip(this.btnGuardarDireccion, "Guardar Status de Dirección");
            this.ttMensaje.SetToolTip(this.btnModificarAlmacen, "Click para modificar Status de Almacen");
            this.ttMensaje.SetToolTip(this.btnModificarCompra, "Click para modificar Status de Compra");
            this.ttMensaje.SetToolTip(this.btnModificarDireccion, "Click para modificar Status de Dirección");
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

        //Método BuscarRequisicion
        private void BuscarRequisicion()
        {
            this.dataListado.DataSource = NRequisicion.BuscarRequisicion(this.txtBuscar.Text);
        }

        //Método BuscarSolicitante
        private void BuscarSolicitante()
        {
            this.dataListado.DataSource = NRequisicion.BuscarIdSolicitante(this.txtBuscar.Text);
        }

        //Método BuscarOrdenTrabajo
        private void BuscarOrdenTrabajo()
        {
            this.dataListado.DataSource = NRequisicion.BuscarOrdenTrabajo(this.txtBuscar.Text);
        }

        //Método BuscarFecha
        private void BuscarFecha()
        {
            this.dataListado.DataSource = NRequisicion.BuscarFechaSolicitud(this.dateTimePicker1.Text,this.dateTimePicker2.Text);
        }

        //Método MostrarNombre
        private string MostrarNombre(int pos)
        {
            string cadena = Convert.ToString(this.dataDetalleListado.CurrentRow.Cells[pos].Value);
            this.dataGridView1.DataSource = NUsuario.BuscarId(cadena);
            string cadena1 = Convert.ToString(this.dataGridView1.CurrentRow.Cells[1].Value);
            return cadena1;
        }

        //Método cambiar nombre columnas
        private void NombreColumnas()
        {
            this.dataListado.Columns[0].HeaderText = "Num Requisición";
            this.dataListado.Columns[1].HeaderText = "Id Solicitante";
            this.dataListado.Columns[2].HeaderText = "Solicitante";
            this.dataListado.Columns[3].HeaderText = "Caracter";
            this.dataListado.Columns[4].HeaderText = "Fecha Solicitud";
            this.dataListado.Columns[5].HeaderText = "Orden Trabajo";
            this.dataListado.Columns[0].Width = 60;
            this.dataListado.Columns[1].Width = 30;
            this.dataListado.Columns[2].Width = 200;
            this.dataListado.Columns[3].Width = 100;
            this.dataListado.Columns[4].Width = 100;
            this.dataListado.Columns[5].Width = 100;

            this.dataDetalleListado.Columns[1].HeaderText = "Id";
            this.dataDetalleListado.Columns[2].HeaderText = "Num Requisición";
            this.dataDetalleListado.Columns[3].HeaderText = "Cantidad";
            this.dataDetalleListado.Columns[4].HeaderText = "Stock";
            this.dataDetalleListado.Columns[5].HeaderText = "Descripción";
            this.dataDetalleListado.Columns[6].HeaderText = "Unidad";
            this.dataDetalleListado.Columns[7].HeaderText = "Status Almacen";
            this.dataDetalleListado.Columns[8].HeaderText = "Status Compra";
            this.dataDetalleListado.Columns[9].HeaderText = "Status Direccion";
            this.dataDetalleListado.Columns[10].HeaderText = "Fecha Almacen";
            this.dataDetalleListado.Columns[11].HeaderText = "Fecha Compra";
            this.dataDetalleListado.Columns[12].HeaderText = "Fecha Dirección";
            this.dataDetalleListado.Columns[13].HeaderText = "Id Almacenero";
            this.dataDetalleListado.Columns[14].HeaderText = "Id Compra";
            this.dataDetalleListado.Columns[15].HeaderText = "Id Direccion";
            this.dataDetalleListado.Columns[16].HeaderText = "Justificación";
            this.dataDetalleListado.Columns[3].Width = 70;
            this.dataDetalleListado.Columns[5].Width = 250;
            this.dataDetalleListado.Columns[6].Width = 100;
            this.dataDetalleListado.Columns[7].Width = 100;
            this.dataDetalleListado.Columns[16].Width = 250;
        }

        //Método para ocultar columnas
        private void OcultarColumnas()
        {
            this.dataListado.Columns[1].Visible = false;
            this.dataDetalleListado.Columns[0].Visible = false;
            this.dataDetalleListado.Columns[1].Visible = false;
            this.dataDetalleListado.Columns[2].Visible = false;
            this.dataDetalleListado.Columns[4].Visible = false;
            this.dataDetalleListado.Columns[7].Visible = false;
            this.dataDetalleListado.Columns[8].Visible = false;
            this.dataDetalleListado.Columns[9].Visible = false;
            this.dataDetalleListado.Columns[10].Visible = false;
            this.dataDetalleListado.Columns[11].Visible = false;
            this.dataDetalleListado.Columns[12].Visible = false;
            this.dataDetalleListado.Columns[13].Visible = false;
            this.dataDetalleListado.Columns[14].Visible = false;
            this.dataDetalleListado.Columns[15].Visible = false;
            this.ckSelectAll.Visible = false;
        }

        //Método MostrarDatalistado
        private void Mostrar()
        {
            this.dataListado.DataSource = NRequisicion.Mostrar();      
        }

        //Método MostrarDataDetalleListado
        private void MostrarDetalle()
        {
            this.dataDetalleListado.DataSource = NDetalleRequisicion.BuscarNumRequisicion(this.txtIdRequisicion.Text);
            this.OcultarColumnas();
        }

        //Método Botones
        private void Botones()
        {
            if (Acceso.Equals("1"))
            {
                this.btnModificarAlmacen.Enabled = false;
                this.btnModificarCompra.Enabled = false;
                this.btnModificarDireccion.Enabled = false;
                this.btnGuardarAlmacen.Enabled = false;
                this.btnGuardarCompra.Enabled = false;
                this.btnGuardarDireccion.Enabled = false;
                this.tsGuardar.Enabled = false;
                this.tsModificar.Enabled = false;
            }
            else if (Acceso.Equals("2"))
            {
                this.btnModificarAlmacen.Enabled = true;
                this.btnModificarCompra.Enabled = false;
                this.btnModificarDireccion.Enabled = false;
                this.btnGuardarAlmacen.Enabled = true;
                this.btnGuardarCompra.Enabled = false;
                this.btnGuardarDireccion.Enabled = false;
                this.tsGuardar.Enabled = false;
                this.tsModificar.Enabled = true;
            }
            else if (Acceso.Equals("3"))
            {
                this.btnModificarAlmacen.Enabled = false;
                this.btnModificarCompra.Enabled = true;
                this.btnModificarDireccion.Enabled = false;
                this.btnGuardarAlmacen.Enabled = false;
                this.btnGuardarCompra.Enabled = true;
                this.btnGuardarDireccion.Enabled = false;
                this.tsGuardar.Enabled = false;
                this.tsModificar.Enabled = true;
            }
            else
            {
                this.btnModificarAlmacen.Enabled = true;
                this.btnModificarCompra.Enabled = true;
                this.btnModificarDireccion.Enabled = true;
                this.btnGuardarAlmacen.Enabled = true;
                this.btnGuardarCompra.Enabled = true;
                this.btnGuardarDireccion.Enabled = true;
                this.tsGuardar.Enabled = false;
                this.tsModificar.Enabled = true;
            }
            this.cbStatusAlmacen.Visible = false;
            this.cbStatusCompra.Visible = false;
            this.cbStatusDireccion.Visible = false; 
            this.btnGuardarAlmacen.Visible = false;
            this.btnGuardarCompra.Visible = false;
            this.btnGuardarDireccion.Visible = false;
        }

        private void frmConsultaRequisicion_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            if (this.dataDetalleListado.Rows.Count > 0 && this.dataListado.Rows.Count > 0)
            {
                this.NombreColumnas();
                //this.OcultarColumnas();
            }
            this.cbBuscar.SelectedIndex = 0;
            this.Botones();
        }

        private void dataListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dataListado.Rows.Count > 0)
            {
                this.txtIdRequisicion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells[0].Value);
                this.txtSolicitante.Text = Convert.ToString(this.dataListado.CurrentRow.Cells[2].Value);
                this.txtCaracter.Text = Convert.ToString(this.dataListado.CurrentRow.Cells[3].Value);
                this.txtFechaSolicitud.Text = Convert.ToString(this.dataListado.CurrentRow.Cells[4].Value);
                this.txtOrdenTrabajo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells[5].Value);
                MostrarDetalle();                
            }    
        }

        private void dataDetalleListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dataDetalleListado.Rows.Count > 0)
            {
                this.txtRespAlmacen.Text = this.MostrarNombre(13);
                this.txtRespCompra.Text = this.MostrarNombre(14);
                this.txtRespDireccion.Text = this.MostrarNombre(15);

                if (this.MostrarNombre(13).Equals("SISTEMA SISTEMA"))
                {
                    this.txtRespAlmacen.Text = "";
                }
                else
                {
                    this.txtRespAlmacen.Text = this.MostrarNombre(13);
                }

                if (this.MostrarNombre(14).Equals("SISTEMA SISTEMA"))
                {
                    this.txtRespCompra.Text = "";
                }
                else
                {
                    this.txtRespCompra.Text = this.MostrarNombre(14);
                }

                if (this.MostrarNombre(15).Equals("SISTEMA SISTEMA"))
                {
                    this.txtRespDireccion.Text = "";
                }
                else
                {
                    this.txtRespDireccion.Text = this.MostrarNombre(15);
                }

                this.txtStatusAlmacen.Text = Convert.ToString(this.dataDetalleListado.CurrentRow.Cells[7].Value);
                this.txtStatusCompra.Text = Convert.ToString(this.dataDetalleListado.CurrentRow.Cells[8].Value);
                this.txtStatusDireccion.Text = Convert.ToString(this.dataDetalleListado.CurrentRow.Cells[9].Value);
                this.txtFechaAlmacen.Text = Convert.ToString(this.dataDetalleListado.CurrentRow.Cells[10].Value);
                this.txtFechaCompra.Text = Convert.ToString(this.dataDetalleListado.CurrentRow.Cells[11].Value);
                this.txtFechaDireccion.Text = Convert.ToString(this.dataDetalleListado.CurrentRow.Cells[12].Value);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscar.SelectedIndex == 0)
            {
                this.BuscarRequisicion();
            }
            else if (cbBuscar.SelectedIndex == 1)
            {                
                ((DataTable)dataListado.DataSource).DefaultView.RowFilter = string.Format("nombreSolicitante like '%{0}%'", txtBuscar.Text.Trim().Replace("'", "''"));
            }
            else if (cbBuscar.SelectedIndex == 2)
            {
                this.BuscarOrdenTrabajo();
            }
        }

        private void btnModificarAlmacen_Click(object sender, EventArgs e)
        {
            this.btnGuardarAlmacen.Visible = true;
            this.btnModificarAlmacen.Visible = false;
            this.tsModificar.Enabled = false;
            this.cbStatusAlmacen.Visible = true;
            this.cbStatusAlmacen.SelectedItem = Convert.ToString(this.dataDetalleListado.CurrentRow.Cells[7].Value);
        }

        private void btnModificarCompra_Click(object sender, EventArgs e)
        {
            this.btnGuardarCompra.Visible = true;
            this.btnModificarCompra.Visible = false;
            this.tsModificar.Enabled = false;
            this.cbStatusCompra.Visible = true;
            this.cbStatusCompra.SelectedItem = Convert.ToString(this.dataDetalleListado.CurrentRow.Cells[8].Value);
        }

        private void btnModificarDireccion_Click(object sender, EventArgs e)
        {
            this.btnGuardarDireccion.Visible = true;
            this.btnModificarDireccion.Visible = false;
            this.tsModificar.Enabled = false;
            this.cbStatusDireccion.Visible = true;
            this.cbStatusDireccion.SelectedItem = Convert.ToString(this.dataDetalleListado.CurrentRow.Cells[9].Value);
        }

        private void btnGuardarAlmacen_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.cbStatusAlmacen.SelectedItem == null)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(this.cbStatusAlmacen, "Selecione el Status");
                }
                else
                {
                    rpta = NDetalleRequisicion.EditarStatusAlmacen(Convert.ToInt32(this.dataDetalleListado.CurrentRow.Cells[1].Value), this.cbStatusAlmacen.Text.Trim(), DateTime.Now, Convert.ToInt32(IdTrabajador));

                    if (rpta.Equals("OK"))
                    {                      
                        this.MensajeOK("Se actualizó de forma correcta el registro");
                        this.btnModificarAlmacen.Visible = true;
                        this.btnGuardarAlmacen.Visible = false;
                        this.cbStatusAlmacen.Visible = false;
                        this.tsModificar.Enabled = true;
                        MostrarDetalle();
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnGuardarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.cbStatusCompra.SelectedItem == null)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(this.cbStatusCompra, "Selecione el Status");
                }
                else
                {
                    rpta = NDetalleRequisicion.EditarStatusCompra(Convert.ToInt32(this.dataDetalleListado.CurrentRow.Cells[1].Value), this.cbStatusCompra.Text.Trim(), DateTime.Now, Convert.ToInt32(IdTrabajador));

                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se actualizó de forma correcta el registro");
                        this.btnModificarCompra.Visible = true;
                        this.btnGuardarCompra.Visible = false;
                        this.cbStatusCompra.Visible = false;
                        this.tsModificar.Enabled = true;
                        MostrarDetalle();
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnGuardarDireccion_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.cbStatusDireccion.SelectedItem == null)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(this.cbStatusDireccion, "Selecione el Status");
                }
                else
                {
                    rpta = NDetalleRequisicion.EditarStatusDireccion(Convert.ToInt32(this.dataDetalleListado.CurrentRow.Cells[1].Value), this.cbStatusDireccion.Text.Trim(), DateTime.Now, Convert.ToInt32(IdTrabajador));

                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se actualizó de forma correcta el registro");
                        this.btnModificarDireccion.Visible = true;
                        this.btnGuardarDireccion.Visible = false;
                        this.cbStatusDireccion.Visible = false;
                        this.tsModificar.Enabled = true;
                        MostrarDetalle();
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtStatusAlmacen_TextChanged(object sender, EventArgs e)
        {
            if (txtStatusAlmacen.Text.Equals("POR REVISAR"))
            {
                txtStatusAlmacen.BackColor = Color.Yellow;
            }
            else if (txtStatusAlmacen.Text.Equals("EXISTENTE"))
            {
                txtStatusAlmacen.BackColor = Color.GreenYellow;
            }
            else if (txtStatusAlmacen.Text.Equals("APROBADO"))
            {
                txtStatusAlmacen.BackColor = Color.Green;
            }
            else if (txtStatusAlmacen.Text.Equals("NO APROBADO"))
            {
                txtStatusAlmacen.BackColor = Color.Red;
            }
            else if (txtStatusAlmacen.Text.Equals("PEDIDO"))
            {
                txtStatusAlmacen.BackColor = Color.LightSeaGreen;
            }
            else if (txtStatusAlmacen.Text.Equals("SURTIDO"))
            {
                txtStatusAlmacen.BackColor = Color.Teal;
            }
            else
            {
                txtStatusAlmacen.BackColor = Color.White;
            }
        }

        private void txtStatusCompra_TextChanged(object sender, EventArgs e)
        {
            if (txtStatusCompra.Text.Equals("POR REVISAR"))
            {
                txtStatusCompra.BackColor = Color.Yellow;
            }
            else if (txtStatusCompra.Text.Equals("EXISTENTE"))
            {
                txtStatusCompra.BackColor = Color.GreenYellow;
            }
            else if (txtStatusCompra.Text.Equals("APROBADO"))
            {
                txtStatusCompra.BackColor = Color.Green;
            }
            else if (txtStatusCompra.Text.Equals("NO APROBADO"))
            {
                txtStatusCompra.BackColor = Color.Red;
            }
            else if (txtStatusCompra.Text.Equals("PEDIDO"))
            {
                txtStatusCompra.BackColor = Color.LightSeaGreen;
            }
            else if (txtStatusCompra.Text.Equals("SURTIDO"))
            {
                txtStatusCompra.BackColor = Color.Teal;
            }
            else
            {
                txtStatusCompra.BackColor = Color.White;
            }
        }

        private void txtStatusDireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtStatusDireccion.Text.Equals("POR REVISAR"))
            {
                txtStatusDireccion.BackColor = Color.Yellow;
            }
            else if (txtStatusDireccion.Text.Equals("EXISTENTE"))
            {
                txtStatusDireccion.BackColor = Color.GreenYellow;
            }
            else if (txtStatusDireccion.Text.Equals("APROBADO"))
            {
                txtStatusDireccion.BackColor = Color.Green;
            }
            else if (txtStatusDireccion.Text.Equals("NO APROBADO"))
            {
                txtStatusDireccion.BackColor = Color.Red;
            }
            else if (txtStatusDireccion.Text.Equals("PEDIDO"))
            {
                txtStatusDireccion.BackColor = Color.LightSeaGreen;
            }
            else if (txtStatusDireccion.Text.Equals("SURTIDO"))
            {
                txtStatusDireccion.BackColor = Color.Teal;
            }
            else
            {
                txtStatusDireccion.BackColor = Color.White;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                this.MensajeError("La fecha inicial debe ser menor o igual a la fecha final");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                BuscarFecha();
            }
            else
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
            
        }

        private void tsModificar_Click(object sender, EventArgs e)
        {
            this.dataDetalleListado.Columns[0].Visible = true;
            this.tsGuardar.Enabled = true;
            this.tsModificar.Enabled = false;
            this.ckSelectAll.Visible = true;

            if (Acceso.Equals("2")) //Almacen
            {
                this.btnGuardarAlmacen.Enabled = false;
                this.btnModificarAlmacen.Enabled = false;
                this.cbStatusAlmacen.Visible = true;
                this.cbStatusAlmacen.SelectedItem = Convert.ToString(this.dataDetalleListado.CurrentRow.Cells[7].Value);
            }
            else if (Acceso.Equals("3")) //Compra
            {
                this.btnGuardarCompra.Enabled = false;
                this.btnModificarCompra.Enabled = false;
                this.cbStatusCompra.Visible = true;
                this.cbStatusCompra.SelectedItem = Convert.ToString(this.dataDetalleListado.CurrentRow.Cells[8].Value);
            }
            else //Direccion
            {
                this.cbStatusAlmacen.Visible = true;
                this.cbStatusCompra.Visible = true;
                this.cbStatusDireccion.Visible = true;
                this.btnGuardarDireccion.Enabled = false;
                this.btnModificarDireccion.Enabled = false;
                this.btnGuardarAlmacen.Enabled = false;
                this.btnModificarAlmacen.Enabled = false;
                this.btnGuardarCompra.Enabled = false;
                this.btnModificarCompra.Enabled = false;
                this.cbStatusAlmacen.SelectedItem = Convert.ToString(this.dataDetalleListado.CurrentRow.Cells[7].Value);
                this.cbStatusCompra.SelectedItem = Convert.ToString(this.dataDetalleListado.CurrentRow.Cells[8].Value);
                this.cbStatusDireccion.SelectedItem = Convert.ToString(this.dataDetalleListado.CurrentRow.Cells[9].Value);
            }
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea modificar el status de los registros?", "SisReq", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataDetalleListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            if (Acceso.Equals("2")) //Almacen
                            {
                                Rpta = NDetalleRequisicion.EditarStatusAlmacen(Convert.ToInt32(Codigo), this.cbStatusAlmacen.Text.Trim(), DateTime.Now, Convert.ToInt32(IdTrabajador));
                            }
                            else if (Acceso.Equals("3")) //Compra
                            {
                                Rpta = NDetalleRequisicion.EditarStatusCompra(Convert.ToInt32(Codigo), this.cbStatusCompra.Text.Trim(), DateTime.Now, Convert.ToInt32(IdTrabajador));
                            }                            
                            else //Direccion
                            {
                                Rpta = NDetalleRequisicion.EditarStatusAlmacen(Convert.ToInt32(Codigo), this.cbStatusAlmacen.Text.Trim(), DateTime.Now, Convert.ToInt32(IdTrabajador));
                                Rpta = NDetalleRequisicion.EditarStatusCompra(Convert.ToInt32(Codigo), this.cbStatusCompra.Text.Trim(), DateTime.Now, Convert.ToInt32(IdTrabajador));
                                Rpta = NDetalleRequisicion.EditarStatusDireccion(Convert.ToInt32(Codigo), this.cbStatusDireccion.Text.Trim(), DateTime.Now, Convert.ToInt32(IdTrabajador));
                            }
                        }
                    }
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se modificaron correctamente los registros");
                        if (Acceso.Equals("2")) //Almacen
                        {
                            this.btnGuardarAlmacen.Enabled = true;
                            this.btnModificarAlmacen.Enabled = true;
                            this.cbStatusAlmacen.Visible = false;
                        }
                        else if (Acceso.Equals("3")) //Compra
                        {
                            this.btnGuardarCompra.Enabled = true;
                            this.btnModificarCompra.Enabled = true;
                            this.cbStatusCompra.Visible = false;
                        }
                        else //Direccion
                        {
                            this.btnGuardarAlmacen.Enabled = true;
                            this.btnModificarAlmacen.Enabled = true;
                            this.cbStatusAlmacen.Visible = false;
                            this.btnGuardarCompra.Enabled = true;
                            this.btnModificarCompra.Enabled = true;
                            this.cbStatusCompra.Visible = false;
                            this.btnGuardarDireccion.Enabled = true;
                            this.btnModificarDireccion.Enabled = true;
                            this.cbStatusDireccion.Visible = false;
                        }
                    }
                    else
                    {
                        MensajeError("Debe seleccionar al menos un item");
                    }
                    this.MostrarDetalle();
                    this.tsModificar.Enabled = true;
                    this.tsGuardar.Enabled = false;
                    this.ckSelectAll.Visible = false;
                    this.ckSelectAll.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            this.dataDetalleListado.Columns[0].Visible = false;
        }

        private void dataDetalleListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataDetalleListado.Columns[0].Index && e.RowIndex >= dataDetalleListado.Rows[0].Index)
            {
                DataGridViewCheckBoxCell ChkModificar = (DataGridViewCheckBoxCell)dataDetalleListado.Rows[e.RowIndex].Cells[0];
                ChkModificar.Value = !Convert.ToBoolean(ChkModificar.Value);
            }
        }

        private void ckSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (ckSelectAll.Checked)
            {
                for (int i = 0; i < dataDetalleListado.RowCount; i++)
                {
                    dataDetalleListado.Rows[i].Cells[0].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < dataDetalleListado.RowCount; i++)
                {
                    dataDetalleListado.Rows[i].Cells[0].Value = false;
                }
            }
            
        }
    }
}
