namespace CapaPresentacion
{
    partial class frmConsultaRequisicion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaRequisicion));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdRequisicion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFechaSolicitud = new System.Windows.Forms.TextBox();
            this.txtCaracter = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxDireccion = new System.Windows.Forms.GroupBox();
            this.cbStatusDireccion = new System.Windows.Forms.ComboBox();
            this.txtStatusDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRespDireccion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFechaDireccion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBoxAlmacen = new System.Windows.Forms.GroupBox();
            this.cbStatusAlmacen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatusAlmacen = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFechaAlmacen = new System.Windows.Forms.TextBox();
            this.txtRespAlmacen = new System.Windows.Forms.TextBox();
            this.groupBoxCompra = new System.Windows.Forms.GroupBox();
            this.cbStatusCompra = new System.Windows.Forms.ComboBox();
            this.txtStatusCompra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFechaCompra = new System.Windows.Forms.TextBox();
            this.txtRespCompra = new System.Windows.Forms.TextBox();
            this.dataDetalleListado = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnModificarDireccion = new System.Windows.Forms.Button();
            this.btnModificarCompra = new System.Windows.Forms.Button();
            this.btnModificarAlmacen = new System.Windows.Forms.Button();
            this.btnGuardarDireccion = new System.Windows.Forms.Button();
            this.btnGuardarCompra = new System.Windows.Forms.Button();
            this.btnGuardarAlmacen = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.label21 = new System.Windows.Forms.Label();
            this.txtOrdenTrabajo = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsModificar = new System.Windows.Forms.ToolStripButton();
            this.tsGuardar = new System.Windows.Forms.ToolStripButton();
            this.ckSelectAll = new System.Windows.Forms.CheckBox();
            this.Modificar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.groupBoxDireccion.SuspendLayout();
            this.groupBoxAlmacen.SuspendLayout();
            this.groupBoxCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetalleListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker2);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.cbBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.dataListado);
            this.splitContainer1.Panel1.Controls.Add(this.txtBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.label17);
            this.splitContainer1.Panel1.Controls.Add(this.label16);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ckSelectAll);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxDireccion);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxAlmacen);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxCompra);
            this.splitContainer1.Panel2.Controls.Add(this.dataDetalleListado);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.btnModificarDireccion);
            this.splitContainer1.Panel2.Controls.Add(this.btnModificarCompra);
            this.splitContainer1.Panel2.Controls.Add(this.btnModificarAlmacen);
            this.splitContainer1.Panel2.Controls.Add(this.btnGuardarDireccion);
            this.splitContainer1.Panel2.Controls.Add(this.btnGuardarCompra);
            this.splitContainer1.Panel2.Controls.Add(this.btnGuardarAlmacen);
            this.splitContainer1.Size = new System.Drawing.Size(1105, 513);
            this.splitContainer1.SplitterDistance = 511;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtIdRequisicion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSolicitante);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtFechaSolicitud);
            this.groupBox1.Controls.Add(this.txtOrdenTrabajo);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtCaracter);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(25, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 145);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Id Requisición:";
            // 
            // txtIdRequisicion
            // 
            this.txtIdRequisicion.Location = new System.Drawing.Point(94, 13);
            this.txtIdRequisicion.Name = "txtIdRequisicion";
            this.txtIdRequisicion.ReadOnly = true;
            this.txtIdRequisicion.Size = new System.Drawing.Size(68, 20);
            this.txtIdRequisicion.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Solicitante:";
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Location = new System.Drawing.Point(94, 39);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.ReadOnly = true;
            this.txtSolicitante.Size = new System.Drawing.Size(234, 20);
            this.txtSolicitante.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fecha Solicitud:";
            // 
            // txtFechaSolicitud
            // 
            this.txtFechaSolicitud.Location = new System.Drawing.Point(94, 65);
            this.txtFechaSolicitud.Name = "txtFechaSolicitud";
            this.txtFechaSolicitud.ReadOnly = true;
            this.txtFechaSolicitud.Size = new System.Drawing.Size(152, 20);
            this.txtFechaSolicitud.TabIndex = 2;
            // 
            // txtCaracter
            // 
            this.txtCaracter.Location = new System.Drawing.Point(94, 91);
            this.txtCaracter.Name = "txtCaracter";
            this.txtCaracter.ReadOnly = true;
            this.txtCaracter.Size = new System.Drawing.Size(113, 20);
            this.txtCaracter.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Caracter:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(49, 299);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Filtrar por Fecha:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(317, 297);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(203, 297);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbBuscar
            // 
            this.cbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Items.AddRange(new object[] {
            "N° Requisición",
            "Solicitante",
            "O.T."});
            this.cbBuscar.Location = new System.Drawing.Point(95, 262);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(88, 21);
            this.cbBuscar.TabIndex = 3;
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataListado.Location = new System.Drawing.Point(0, 0);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(509, 257);
            this.dataListado.TabIndex = 0;
            this.dataListado.SelectionChanged += new System.EventHandler(this.dataListado_SelectionChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(189, 262);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(257, 20);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(160, 301);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Entre";
            this.label17.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(297, 301);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Y";
            this.label16.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Buscar:";
            // 
            // groupBoxDireccion
            // 
            this.groupBoxDireccion.Controls.Add(this.cbStatusDireccion);
            this.groupBoxDireccion.Controls.Add(this.txtStatusDireccion);
            this.groupBoxDireccion.Controls.Add(this.label4);
            this.groupBoxDireccion.Controls.Add(this.txtRespDireccion);
            this.groupBoxDireccion.Controls.Add(this.label12);
            this.groupBoxDireccion.Controls.Add(this.txtFechaDireccion);
            this.groupBoxDireccion.Controls.Add(this.label15);
            this.groupBoxDireccion.Location = new System.Drawing.Point(18, 426);
            this.groupBoxDireccion.Name = "groupBoxDireccion";
            this.groupBoxDireccion.Size = new System.Drawing.Size(492, 72);
            this.groupBoxDireccion.TabIndex = 3;
            this.groupBoxDireccion.TabStop = false;
            this.groupBoxDireccion.Text = "Dirección";
            // 
            // cbStatusDireccion
            // 
            this.cbStatusDireccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusDireccion.FormattingEnabled = true;
            this.cbStatusDireccion.Items.AddRange(new object[] {
            "POR REVISAR",
            "EXISTENTE",
            "APROBADO",
            "NO APROBADO",
            "PEDIDO",
            "SURTIDO"});
            this.cbStatusDireccion.Location = new System.Drawing.Point(6, 37);
            this.cbStatusDireccion.Name = "cbStatusDireccion";
            this.cbStatusDireccion.Size = new System.Drawing.Size(134, 23);
            this.cbStatusDireccion.TabIndex = 4;
            // 
            // txtStatusDireccion
            // 
            this.txtStatusDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusDireccion.Location = new System.Drawing.Point(6, 39);
            this.txtStatusDireccion.Name = "txtStatusDireccion";
            this.txtStatusDireccion.ReadOnly = true;
            this.txtStatusDireccion.Size = new System.Drawing.Size(134, 21);
            this.txtStatusDireccion.TabIndex = 2;
            this.txtStatusDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStatusDireccion.TextChanged += new System.EventHandler(this.txtStatusDireccion_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Status";
            // 
            // txtRespDireccion
            // 
            this.txtRespDireccion.Location = new System.Drawing.Point(307, 39);
            this.txtRespDireccion.Name = "txtRespDireccion";
            this.txtRespDireccion.ReadOnly = true;
            this.txtRespDireccion.Size = new System.Drawing.Size(173, 20);
            this.txtRespDireccion.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(205, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Fecha";
            // 
            // txtFechaDireccion
            // 
            this.txtFechaDireccion.Location = new System.Drawing.Point(146, 39);
            this.txtFechaDireccion.Name = "txtFechaDireccion";
            this.txtFechaDireccion.ReadOnly = true;
            this.txtFechaDireccion.Size = new System.Drawing.Size(155, 20);
            this.txtFechaDireccion.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(359, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Responsable";
            // 
            // groupBoxAlmacen
            // 
            this.groupBoxAlmacen.Controls.Add(this.cbStatusAlmacen);
            this.groupBoxAlmacen.Controls.Add(this.label2);
            this.groupBoxAlmacen.Controls.Add(this.txtStatusAlmacen);
            this.groupBoxAlmacen.Controls.Add(this.label10);
            this.groupBoxAlmacen.Controls.Add(this.label13);
            this.groupBoxAlmacen.Controls.Add(this.txtFechaAlmacen);
            this.groupBoxAlmacen.Controls.Add(this.txtRespAlmacen);
            this.groupBoxAlmacen.Location = new System.Drawing.Point(18, 270);
            this.groupBoxAlmacen.Name = "groupBoxAlmacen";
            this.groupBoxAlmacen.Size = new System.Drawing.Size(492, 72);
            this.groupBoxAlmacen.TabIndex = 3;
            this.groupBoxAlmacen.TabStop = false;
            this.groupBoxAlmacen.Text = "Almacen";
            // 
            // cbStatusAlmacen
            // 
            this.cbStatusAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusAlmacen.FormattingEnabled = true;
            this.cbStatusAlmacen.Items.AddRange(new object[] {
            "POR REVISAR",
            "EXISTENTE",
            "APROBADO",
            "NO APROBADO",
            "PEDIDO",
            "SURTIDO"});
            this.cbStatusAlmacen.Location = new System.Drawing.Point(6, 38);
            this.cbStatusAlmacen.Name = "cbStatusAlmacen";
            this.cbStatusAlmacen.Size = new System.Drawing.Size(134, 23);
            this.cbStatusAlmacen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status";
            // 
            // txtStatusAlmacen
            // 
            this.txtStatusAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusAlmacen.Location = new System.Drawing.Point(6, 40);
            this.txtStatusAlmacen.Name = "txtStatusAlmacen";
            this.txtStatusAlmacen.ReadOnly = true;
            this.txtStatusAlmacen.Size = new System.Drawing.Size(134, 21);
            this.txtStatusAlmacen.TabIndex = 2;
            this.txtStatusAlmacen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStatusAlmacen.TextChanged += new System.EventHandler(this.txtStatusAlmacen_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(205, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Fecha";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(359, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Responsable";
            // 
            // txtFechaAlmacen
            // 
            this.txtFechaAlmacen.Location = new System.Drawing.Point(146, 40);
            this.txtFechaAlmacen.Name = "txtFechaAlmacen";
            this.txtFechaAlmacen.ReadOnly = true;
            this.txtFechaAlmacen.Size = new System.Drawing.Size(155, 20);
            this.txtFechaAlmacen.TabIndex = 2;
            // 
            // txtRespAlmacen
            // 
            this.txtRespAlmacen.Location = new System.Drawing.Point(307, 40);
            this.txtRespAlmacen.Name = "txtRespAlmacen";
            this.txtRespAlmacen.ReadOnly = true;
            this.txtRespAlmacen.Size = new System.Drawing.Size(173, 20);
            this.txtRespAlmacen.TabIndex = 2;
            // 
            // groupBoxCompra
            // 
            this.groupBoxCompra.Controls.Add(this.cbStatusCompra);
            this.groupBoxCompra.Controls.Add(this.txtStatusCompra);
            this.groupBoxCompra.Controls.Add(this.label3);
            this.groupBoxCompra.Controls.Add(this.label11);
            this.groupBoxCompra.Controls.Add(this.label14);
            this.groupBoxCompra.Controls.Add(this.txtFechaCompra);
            this.groupBoxCompra.Controls.Add(this.txtRespCompra);
            this.groupBoxCompra.Location = new System.Drawing.Point(18, 348);
            this.groupBoxCompra.Name = "groupBoxCompra";
            this.groupBoxCompra.Size = new System.Drawing.Size(492, 72);
            this.groupBoxCompra.TabIndex = 3;
            this.groupBoxCompra.TabStop = false;
            this.groupBoxCompra.Text = "Compra";
            // 
            // cbStatusCompra
            // 
            this.cbStatusCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusCompra.FormattingEnabled = true;
            this.cbStatusCompra.Items.AddRange(new object[] {
            "POR REVISAR",
            "EXISTENTE",
            "APROBADO",
            "NO APROBADO",
            "PEDIDO",
            "SURTIDO"});
            this.cbStatusCompra.Location = new System.Drawing.Point(6, 37);
            this.cbStatusCompra.Name = "cbStatusCompra";
            this.cbStatusCompra.Size = new System.Drawing.Size(134, 23);
            this.cbStatusCompra.TabIndex = 4;
            // 
            // txtStatusCompra
            // 
            this.txtStatusCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusCompra.Location = new System.Drawing.Point(6, 39);
            this.txtStatusCompra.Name = "txtStatusCompra";
            this.txtStatusCompra.ReadOnly = true;
            this.txtStatusCompra.Size = new System.Drawing.Size(134, 21);
            this.txtStatusCompra.TabIndex = 2;
            this.txtStatusCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStatusCompra.TextChanged += new System.EventHandler(this.txtStatusCompra_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(205, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Fecha";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(359, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Responsable";
            // 
            // txtFechaCompra
            // 
            this.txtFechaCompra.Location = new System.Drawing.Point(146, 39);
            this.txtFechaCompra.Name = "txtFechaCompra";
            this.txtFechaCompra.ReadOnly = true;
            this.txtFechaCompra.Size = new System.Drawing.Size(155, 20);
            this.txtFechaCompra.TabIndex = 2;
            // 
            // txtRespCompra
            // 
            this.txtRespCompra.Location = new System.Drawing.Point(307, 39);
            this.txtRespCompra.Name = "txtRespCompra";
            this.txtRespCompra.ReadOnly = true;
            this.txtRespCompra.Size = new System.Drawing.Size(173, 20);
            this.txtRespCompra.TabIndex = 2;
            // 
            // dataDetalleListado
            // 
            this.dataDetalleListado.AllowUserToAddRows = false;
            this.dataDetalleListado.AllowUserToDeleteRows = false;
            this.dataDetalleListado.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDetalleListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataDetalleListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDetalleListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar});
            this.dataDetalleListado.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataDetalleListado.Location = new System.Drawing.Point(0, 0);
            this.dataDetalleListado.MultiSelect = false;
            this.dataDetalleListado.Name = "dataDetalleListado";
            this.dataDetalleListado.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDetalleListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataDetalleListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDetalleListado.Size = new System.Drawing.Size(588, 219);
            this.dataDetalleListado.TabIndex = 0;
            this.dataDetalleListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDetalleListado_CellContentClick);
            this.dataDetalleListado.SelectionChanged += new System.EventHandler(this.dataDetalleListado_SelectionChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 33);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnModificarDireccion
            // 
            this.btnModificarDireccion.BackgroundImage = global::CapaPresentacion.Properties.Resources.modificar_azul;
            this.btnModificarDireccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarDireccion.Location = new System.Drawing.Point(516, 458);
            this.btnModificarDireccion.Name = "btnModificarDireccion";
            this.btnModificarDireccion.Size = new System.Drawing.Size(32, 32);
            this.btnModificarDireccion.TabIndex = 4;
            this.btnModificarDireccion.UseVisualStyleBackColor = true;
            this.btnModificarDireccion.Click += new System.EventHandler(this.btnModificarDireccion_Click);
            // 
            // btnModificarCompra
            // 
            this.btnModificarCompra.BackgroundImage = global::CapaPresentacion.Properties.Resources.modificar_azul;
            this.btnModificarCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarCompra.Location = new System.Drawing.Point(516, 380);
            this.btnModificarCompra.Name = "btnModificarCompra";
            this.btnModificarCompra.Size = new System.Drawing.Size(32, 32);
            this.btnModificarCompra.TabIndex = 4;
            this.btnModificarCompra.UseVisualStyleBackColor = true;
            this.btnModificarCompra.Click += new System.EventHandler(this.btnModificarCompra_Click);
            // 
            // btnModificarAlmacen
            // 
            this.btnModificarAlmacen.BackgroundImage = global::CapaPresentacion.Properties.Resources.modificar_azul;
            this.btnModificarAlmacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarAlmacen.Location = new System.Drawing.Point(516, 303);
            this.btnModificarAlmacen.Name = "btnModificarAlmacen";
            this.btnModificarAlmacen.Size = new System.Drawing.Size(32, 32);
            this.btnModificarAlmacen.TabIndex = 4;
            this.btnModificarAlmacen.UseVisualStyleBackColor = true;
            this.btnModificarAlmacen.Click += new System.EventHandler(this.btnModificarAlmacen_Click);
            // 
            // btnGuardarDireccion
            // 
            this.btnGuardarDireccion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarDireccion.BackgroundImage")));
            this.btnGuardarDireccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarDireccion.Location = new System.Drawing.Point(516, 458);
            this.btnGuardarDireccion.Name = "btnGuardarDireccion";
            this.btnGuardarDireccion.Size = new System.Drawing.Size(32, 32);
            this.btnGuardarDireccion.TabIndex = 5;
            this.btnGuardarDireccion.UseVisualStyleBackColor = true;
            this.btnGuardarDireccion.Click += new System.EventHandler(this.btnGuardarDireccion_Click);
            // 
            // btnGuardarCompra
            // 
            this.btnGuardarCompra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarCompra.BackgroundImage")));
            this.btnGuardarCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarCompra.Location = new System.Drawing.Point(516, 380);
            this.btnGuardarCompra.Name = "btnGuardarCompra";
            this.btnGuardarCompra.Size = new System.Drawing.Size(32, 32);
            this.btnGuardarCompra.TabIndex = 6;
            this.btnGuardarCompra.UseVisualStyleBackColor = true;
            this.btnGuardarCompra.Click += new System.EventHandler(this.btnGuardarCompra_Click);
            // 
            // btnGuardarAlmacen
            // 
            this.btnGuardarAlmacen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarAlmacen.BackgroundImage")));
            this.btnGuardarAlmacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarAlmacen.Location = new System.Drawing.Point(516, 303);
            this.btnGuardarAlmacen.Name = "btnGuardarAlmacen";
            this.btnGuardarAlmacen.Size = new System.Drawing.Size(32, 32);
            this.btnGuardarAlmacen.TabIndex = 7;
            this.btnGuardarAlmacen.UseVisualStyleBackColor = true;
            this.btnGuardarAlmacen.Click += new System.EventHandler(this.btnGuardarAlmacen_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1800000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 120);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "O.T. #:";
            // 
            // txtOrdenTrabajo
            // 
            this.txtOrdenTrabajo.Location = new System.Drawing.Point(94, 117);
            this.txtOrdenTrabajo.Name = "txtOrdenTrabajo";
            this.txtOrdenTrabajo.ReadOnly = true;
            this.txtOrdenTrabajo.Size = new System.Drawing.Size(113, 20);
            this.txtOrdenTrabajo.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsModificar,
            this.tsGuardar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 219);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(588, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsModificar
            // 
            this.tsModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsModificar.Image = global::CapaPresentacion.Properties.Resources.modificar_azul;
            this.tsModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsModificar.Name = "tsModificar";
            this.tsModificar.Size = new System.Drawing.Size(23, 22);
            this.tsModificar.Text = "toolStripButton1";
            this.tsModificar.ToolTipText = "Modificar";
            this.tsModificar.Click += new System.EventHandler(this.tsModificar_Click);
            // 
            // tsGuardar
            // 
            this.tsGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsGuardar.Image = global::CapaPresentacion.Properties.Resources.guardar_azul;
            this.tsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGuardar.Name = "tsGuardar";
            this.tsGuardar.Size = new System.Drawing.Size(23, 22);
            this.tsGuardar.Text = "toolStripButton2";
            this.tsGuardar.ToolTipText = "tsGuardar";
            this.tsGuardar.Click += new System.EventHandler(this.tsGuardar_Click);
            // 
            // ckSelectAll
            // 
            this.ckSelectAll.AutoSize = true;
            this.ckSelectAll.Location = new System.Drawing.Point(45, 4);
            this.ckSelectAll.Name = "ckSelectAll";
            this.ckSelectAll.Size = new System.Drawing.Size(15, 14);
            this.ckSelectAll.TabIndex = 9;
            this.ckSelectAll.UseVisualStyleBackColor = true;
            this.ckSelectAll.CheckedChanged += new System.EventHandler(this.ckSelectAll_CheckedChanged);
            // 
            // Modificar
            // 
            this.Modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Modificar.Frozen = true;
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Width = 5;
            // 
            // frmConsultaRequisicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 513);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaRequisicion";
            this.Text = "Consulta de Requisición";
            this.Load += new System.EventHandler(this.frmConsultaRequisicion_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.groupBoxDireccion.ResumeLayout(false);
            this.groupBoxDireccion.PerformLayout();
            this.groupBoxAlmacen.ResumeLayout(false);
            this.groupBoxAlmacen.PerformLayout();
            this.groupBoxCompra.ResumeLayout(false);
            this.groupBoxCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetalleListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridView dataDetalleListado;
        private System.Windows.Forms.TextBox txtFechaSolicitud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdRequisicion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStatusDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatusCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStatusAlmacen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaracter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxDireccion;
        private System.Windows.Forms.TextBox txtRespDireccion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFechaDireccion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBoxAlmacen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFechaAlmacen;
        private System.Windows.Forms.TextBox txtRespAlmacen;
        private System.Windows.Forms.GroupBox groupBoxCompra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFechaCompra;
        private System.Windows.Forms.TextBox txtRespCompra;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbBuscar;
        private System.Windows.Forms.ComboBox cbStatusAlmacen;
        private System.Windows.Forms.Button btnModificarAlmacen;
        private System.Windows.Forms.ComboBox cbStatusDireccion;
        private System.Windows.Forms.ComboBox cbStatusCompra;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.Button btnModificarDireccion;
        private System.Windows.Forms.Button btnModificarCompra;
        private System.Windows.Forms.Button btnGuardarDireccion;
        private System.Windows.Forms.Button btnGuardarCompra;
        private System.Windows.Forms.Button btnGuardarAlmacen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOrdenTrabajo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsModificar;
        private System.Windows.Forms.ToolStripButton tsGuardar;
        private System.Windows.Forms.CheckBox ckSelectAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Modificar;
    }
}