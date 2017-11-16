﻿namespace ProyectoWF {
    partial class FormularioPedidos {
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gbDatosPedido = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lEmpleadoNombre = new System.Windows.Forms.Label();
            this.tbEmpleadoNombre = new System.Windows.Forms.TextBox();
            this.lViaEnvio = new System.Windows.Forms.Label();
            this.lFechaPedido = new System.Windows.Forms.Label();
            this.lFechaEntrega = new System.Windows.Forms.Label();
            this.lFechaRequerida = new System.Windows.Forms.Label();
            this.dpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.dtFechaRequerida = new System.Windows.Forms.DateTimePicker();
            this.cbViasEnvio = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gbDatosEncio = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lNombreEntrega = new System.Windows.Forms.Label();
            this.lRegionEntrega = new System.Windows.Forms.Label();
            this.lDireccionEntrega = new System.Windows.Forms.Label();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.tbCodigoPostal = new System.Windows.Forms.TextBox();
            this.lCP = new System.Windows.Forms.Label();
            this.cbNombreCliente = new System.Windows.Forms.ComboBox();
            this.lPais = new System.Windows.Forms.Label();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.lCiudadEntrega = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btMenos = new System.Windows.Forms.Button();
            this.btMas = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.lPrecioTotal = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btDarAlta = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProd = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbDatosPedido.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbDatosEncio.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(943, 770);
            this.splitContainer1.SplitterDistance = 310;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer2.Size = new System.Drawing.Size(943, 310);
            this.splitContainer2.SplitterDistance = 146;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.gbDatosPedido, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(943, 146);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // gbDatosPedido
            // 
            this.gbDatosPedido.Controls.Add(this.tableLayoutPanel5);
            this.gbDatosPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatosPedido.Location = new System.Drawing.Point(10, 10);
            this.gbDatosPedido.Margin = new System.Windows.Forms.Padding(10);
            this.gbDatosPedido.Name = "gbDatosPedido";
            this.gbDatosPedido.Size = new System.Drawing.Size(923, 126);
            this.gbDatosPedido.TabIndex = 2;
            this.gbDatosPedido.TabStop = false;
            this.gbDatosPedido.Text = "Datos pedido";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel5.Controls.Add(this.lEmpleadoNombre, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tbEmpleadoNombre, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lViaEnvio, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lFechaPedido, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.lFechaEntrega, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.lFechaRequerida, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.dpFechaEntrega, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.dtFechaPedido, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.dtFechaRequerida, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.cbViasEnvio, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(917, 107);
            this.tableLayoutPanel5.TabIndex = 0;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // lEmpleadoNombre
            // 
            this.lEmpleadoNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lEmpleadoNombre.AutoSize = true;
            this.lEmpleadoNombre.Location = new System.Drawing.Point(3, 11);
            this.lEmpleadoNombre.Name = "lEmpleadoNombre";
            this.lEmpleadoNombre.Size = new System.Drawing.Size(94, 13);
            this.lEmpleadoNombre.TabIndex = 0;
            this.lEmpleadoNombre.Text = "Nombre empleado";
            // 
            // tbEmpleadoNombre
            // 
            this.tbEmpleadoNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmpleadoNombre.Enabled = false;
            this.tbEmpleadoNombre.Location = new System.Drawing.Point(103, 7);
            this.tbEmpleadoNombre.Name = "tbEmpleadoNombre";
            this.tbEmpleadoNombre.Size = new System.Drawing.Size(332, 20);
            this.tbEmpleadoNombre.TabIndex = 1;
            this.tbEmpleadoNombre.TextChanged += new System.EventHandler(this.tbEmpleadoId_TextChanged);
            // 
            // lViaEnvio
            // 
            this.lViaEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lViaEnvio.AutoSize = true;
            this.lViaEnvio.Location = new System.Drawing.Point(3, 46);
            this.lViaEnvio.Name = "lViaEnvio";
            this.lViaEnvio.Size = new System.Drawing.Size(94, 13);
            this.lViaEnvio.TabIndex = 4;
            this.lViaEnvio.Text = "Via Envio";
            // 
            // lFechaPedido
            // 
            this.lFechaPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lFechaPedido.AutoSize = true;
            this.lFechaPedido.Location = new System.Drawing.Point(3, 82);
            this.lFechaPedido.Name = "lFechaPedido";
            this.lFechaPedido.Size = new System.Drawing.Size(94, 13);
            this.lFechaPedido.TabIndex = 2;
            this.lFechaPedido.Text = "Fecha pedido";
            // 
            // lFechaEntrega
            // 
            this.lFechaEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lFechaEntrega.AutoSize = true;
            this.lFechaEntrega.Location = new System.Drawing.Point(461, 11);
            this.lFechaEntrega.Name = "lFechaEntrega";
            this.lFechaEntrega.Size = new System.Drawing.Size(94, 13);
            this.lFechaEntrega.TabIndex = 3;
            this.lFechaEntrega.Text = "Fecha entrega";
            this.lFechaEntrega.Click += new System.EventHandler(this.lFechaEntrega_Click);
            // 
            // lFechaRequerida
            // 
            this.lFechaRequerida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lFechaRequerida.AutoSize = true;
            this.lFechaRequerida.Location = new System.Drawing.Point(461, 46);
            this.lFechaRequerida.Name = "lFechaRequerida";
            this.lFechaRequerida.Size = new System.Drawing.Size(94, 13);
            this.lFechaRequerida.TabIndex = 10;
            this.lFechaRequerida.Text = "Fecha requerida";
            this.lFechaRequerida.Click += new System.EventHandler(this.lFechaRequerida_Click);
            // 
            // dpFechaEntrega
            // 
            this.dpFechaEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dpFechaEntrega.Location = new System.Drawing.Point(561, 7);
            this.dpFechaEntrega.Name = "dpFechaEntrega";
            this.dpFechaEntrega.Size = new System.Drawing.Size(332, 20);
            this.dpFechaEntrega.TabIndex = 11;
            // 
            // dtFechaPedido
            // 
            this.dtFechaPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFechaPedido.Enabled = false;
            this.dtFechaPedido.Location = new System.Drawing.Point(103, 78);
            this.dtFechaPedido.Name = "dtFechaPedido";
            this.dtFechaPedido.Size = new System.Drawing.Size(332, 20);
            this.dtFechaPedido.TabIndex = 12;
            // 
            // dtFechaRequerida
            // 
            this.dtFechaRequerida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFechaRequerida.Location = new System.Drawing.Point(561, 42);
            this.dtFechaRequerida.Name = "dtFechaRequerida";
            this.dtFechaRequerida.Size = new System.Drawing.Size(332, 20);
            this.dtFechaRequerida.TabIndex = 13;
            // 
            // cbViasEnvio
            // 
            this.cbViasEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbViasEnvio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbViasEnvio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbViasEnvio.FormattingEnabled = true;
            this.cbViasEnvio.Location = new System.Drawing.Point(103, 42);
            this.cbViasEnvio.Name = "cbViasEnvio";
            this.cbViasEnvio.Size = new System.Drawing.Size(332, 21);
            this.cbViasEnvio.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.gbDatosEncio, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(943, 160);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // gbDatosEncio
            // 
            this.gbDatosEncio.Controls.Add(this.tableLayoutPanel4);
            this.gbDatosEncio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatosEncio.Location = new System.Drawing.Point(10, 10);
            this.gbDatosEncio.Margin = new System.Windows.Forms.Padding(10);
            this.gbDatosEncio.Name = "gbDatosEncio";
            this.gbDatosEncio.Size = new System.Drawing.Size(923, 140);
            this.gbDatosEncio.TabIndex = 3;
            this.gbDatosEncio.TabStop = false;
            this.gbDatosEncio.Text = "Datos envio";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 8;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.39669F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.80165F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.80165F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.Controls.Add(this.lNombreEntrega, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lRegionEntrega, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.lDireccionEntrega, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbRegion, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.tbCodigoPostal, 6, 1);
            this.tableLayoutPanel4.Controls.Add(this.lCP, 5, 1);
            this.tableLayoutPanel4.Controls.Add(this.cbNombreCliente, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lPais, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.tbCiudad, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lCiudadEntrega, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lTelefono, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tbDireccion, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbTelefono, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.tbPais, 4, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(917, 121);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // lNombreEntrega
            // 
            this.lNombreEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lNombreEntrega.AutoSize = true;
            this.lNombreEntrega.Location = new System.Drawing.Point(3, 13);
            this.lNombreEntrega.Name = "lNombreEntrega";
            this.lNombreEntrega.Size = new System.Drawing.Size(94, 13);
            this.lNombreEntrega.TabIndex = 2;
            this.lNombreEntrega.Text = "Nombre";
            // 
            // lRegionEntrega
            // 
            this.lRegionEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lRegionEntrega.AutoSize = true;
            this.lRegionEntrega.Location = new System.Drawing.Point(455, 53);
            this.lRegionEntrega.Name = "lRegionEntrega";
            this.lRegionEntrega.Size = new System.Drawing.Size(94, 13);
            this.lRegionEntrega.TabIndex = 1;
            this.lRegionEntrega.Text = "Región";
            // 
            // lDireccionEntrega
            // 
            this.lDireccionEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lDireccionEntrega.AutoSize = true;
            this.lDireccionEntrega.Location = new System.Drawing.Point(455, 13);
            this.lDireccionEntrega.Name = "lDireccionEntrega";
            this.lDireccionEntrega.Size = new System.Drawing.Size(94, 13);
            this.lDireccionEntrega.TabIndex = 3;
            this.lDireccionEntrega.Text = "Dirección";
            // 
            // tbRegion
            // 
            this.tbRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRegion.Enabled = false;
            this.tbRegion.Location = new System.Drawing.Point(555, 50);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(112, 20);
            this.tbRegion.TabIndex = 9;
            // 
            // tbCodigoPostal
            // 
            this.tbCodigoPostal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodigoPostal.Enabled = false;
            this.tbCodigoPostal.Location = new System.Drawing.Point(773, 50);
            this.tbCodigoPostal.Name = "tbCodigoPostal";
            this.tbCodigoPostal.Size = new System.Drawing.Size(112, 20);
            this.tbCodigoPostal.TabIndex = 10;
            // 
            // lCP
            // 
            this.lCP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lCP.AutoSize = true;
            this.lCP.Location = new System.Drawing.Point(673, 53);
            this.lCP.Name = "lCP";
            this.lCP.Size = new System.Drawing.Size(94, 13);
            this.lCP.TabIndex = 12;
            this.lCP.Text = "Código postal";
            // 
            // cbNombreCliente
            // 
            this.cbNombreCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNombreCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNombreCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNombreCliente.FormattingEnabled = true;
            this.cbNombreCliente.Location = new System.Drawing.Point(103, 9);
            this.cbNombreCliente.Name = "cbNombreCliente";
            this.cbNombreCliente.Size = new System.Drawing.Size(326, 21);
            this.cbNombreCliente.TabIndex = 6;
            this.cbNombreCliente.SelectedIndexChanged += new System.EventHandler(this.cbNombreCliente_SelectedIndexChanged);
            this.cbNombreCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbNombreCliente_KeyDown);
            this.cbNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNombreCliente_KeyPress);
            this.cbNombreCliente.Validating += new System.ComponentModel.CancelEventHandler(this.cbNombreCliente_Validating);
            // 
            // lPais
            // 
            this.lPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lPais.AutoSize = true;
            this.lPais.Location = new System.Drawing.Point(455, 94);
            this.lPais.Name = "lPais";
            this.lPais.Size = new System.Drawing.Size(94, 13);
            this.lPais.TabIndex = 11;
            this.lPais.Text = "Pais";
            // 
            // tbCiudad
            // 
            this.tbCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCiudad.Enabled = false;
            this.tbCiudad.Location = new System.Drawing.Point(103, 90);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(326, 20);
            this.tbCiudad.TabIndex = 11;
            // 
            // lCiudadEntrega
            // 
            this.lCiudadEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lCiudadEntrega.AutoSize = true;
            this.lCiudadEntrega.Location = new System.Drawing.Point(3, 94);
            this.lCiudadEntrega.Name = "lCiudadEntrega";
            this.lCiudadEntrega.Size = new System.Drawing.Size(94, 13);
            this.lCiudadEntrega.TabIndex = 4;
            this.lCiudadEntrega.Text = "Ciudad";
            // 
            // lTelefono
            // 
            this.lTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lTelefono.AutoSize = true;
            this.lTelefono.Location = new System.Drawing.Point(3, 53);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(94, 13);
            this.lTelefono.TabIndex = 19;
            this.lTelefono.Text = "Teléfono";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.SetColumnSpan(this.tbDireccion, 3);
            this.tbDireccion.Enabled = false;
            this.tbDireccion.Location = new System.Drawing.Point(555, 10);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(330, 20);
            this.tbDireccion.TabIndex = 7;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTelefono.Enabled = false;
            this.tbTelefono.Location = new System.Drawing.Point(103, 50);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(326, 20);
            this.tbTelefono.TabIndex = 8;
            // 
            // tbPais
            // 
            this.tbPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.SetColumnSpan(this.tbPais, 3);
            this.tbPais.Enabled = false;
            this.tbPais.Location = new System.Drawing.Point(555, 90);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(330, 20);
            this.tbPais.TabIndex = 12;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tableLayoutPanel7);
            this.splitContainer3.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer3_Panel2_Paint);
            this.splitContainer3.Size = new System.Drawing.Size(943, 456);
            this.splitContainer3.SplitterDistance = 415;
            this.splitContainer3.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 415F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(943, 415);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 395);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Línea de pedido";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.btMenos, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.btMas, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.btEditar, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.dgProductos, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lPrecioTotal, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.maskedTextBox1, 1, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(917, 376);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // btMenos
            // 
            this.btMenos.Image = global::ProyectoWF.Properties.Resources.if_icon_minus_211864__1_;
            this.btMenos.Location = new System.Drawing.Point(864, 3);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(30, 23);
            this.btMenos.TabIndex = 0;
            this.btMenos.Text = "  -  ";
            this.btMenos.UseVisualStyleBackColor = true;
            // 
            // btMas
            // 
            this.btMas.Image = global::ProyectoWF.Properties.Resources.if_plus_103681;
            this.btMas.Location = new System.Drawing.Point(828, 3);
            this.btMas.Name = "btMas";
            this.btMas.Size = new System.Drawing.Size(30, 23);
            this.btMas.TabIndex = 1;
            this.btMas.Text = " +  ";
            this.btMas.UseVisualStyleBackColor = true;
            this.btMas.Click += new System.EventHandler(this.btMas_Click);
            // 
            // btEditar
            // 
            this.btEditar.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btEditar.Image = global::ProyectoWF.Properties.Resources._183209_16;
            this.btEditar.Location = new System.Drawing.Point(792, 3);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(30, 23);
            this.btEditar.TabIndex = 2;
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // dgProductos
            // 
            this.dgProductos.AllowUserToAddRows = false;
            this.dgProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProd,
            this.cantidad,
            this.descuento,
            this.precioUnidad,
            this.precio});
            this.tableLayoutPanel6.SetColumnSpan(this.dgProductos, 4);
            this.dgProductos.Location = new System.Drawing.Point(15, 32);
            this.dgProductos.Margin = new System.Windows.Forms.Padding(15, 3, 0, 5);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.Size = new System.Drawing.Size(882, 308);
            this.dgProductos.TabIndex = 3;
            this.dgProductos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgProductos_EditingControlShowing);
            // 
            // lPrecioTotal
            // 
            this.lPrecioTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lPrecioTotal.AutoSize = true;
            this.lPrecioTotal.Location = new System.Drawing.Point(726, 354);
            this.lPrecioTotal.Name = "lPrecioTotal";
            this.lPrecioTotal.Size = new System.Drawing.Size(60, 13);
            this.lPrecioTotal.TabIndex = 4;
            this.lPrecioTotal.Text = "Precio total";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.SetColumnSpan(this.maskedTextBox1, 3);
            this.maskedTextBox1.Location = new System.Drawing.Point(792, 350);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(105, 20);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.btDarAlta, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.btCancelar, 2, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(943, 37);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // btDarAlta
            // 
            this.btDarAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btDarAlta.Location = new System.Drawing.Point(777, 7);
            this.btDarAlta.Name = "btDarAlta";
            this.btDarAlta.Size = new System.Drawing.Size(75, 23);
            this.btDarAlta.TabIndex = 6;
            this.btDarAlta.Text = "Dar de alta";
            this.btDarAlta.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.Location = new System.Drawing.Point(858, 7);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            this.textBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox11.Location = new System.Drawing.Point(88, 208);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(351, 20);
            this.textBox11.TabIndex = 13;
            // 
            // idProducto
            // 
            this.idProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idProducto.HeaderText = "Id Producto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // nombreProd
            // 
            this.nombreProd.HeaderText = "Nombre Producto";
            this.nombreProd.Name = "nombreProd";
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // descuento
            // 
            this.descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descuento.HeaderText = "Descuento";
            this.descuento.Name = "descuento";
            // 
            // precioUnidad
            // 
            this.precioUnidad.HeaderText = "Precio unidad";
            this.precioUnidad.Name = "precioUnidad";
            this.precioUnidad.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // FormularioPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 770);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormularioPedidos";
            this.Text = "FormularioPedidos";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbDatosPedido.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.gbDatosEncio.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gbDatosPedido;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lEmpleadoNombre;
        private System.Windows.Forms.TextBox tbEmpleadoNombre;
        private System.Windows.Forms.Label lFechaPedido;
        private System.Windows.Forms.Label lFechaEntrega;
        private System.Windows.Forms.Label lViaEnvio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox gbDatosEncio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox tbCodigoPostal;
        private System.Windows.Forms.Label lNombreEntrega;
        private System.Windows.Forms.Label lDireccionEntrega;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label lCiudadEntrega;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.Label lRegionEntrega;
        private System.Windows.Forms.TextBox tbRegion;
        private System.Windows.Forms.Label lPais;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.Label lCP;
        private System.Windows.Forms.Label lFechaRequerida;
        private System.Windows.Forms.ComboBox cbNombreCliente;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.Button btMas;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btDarAlta;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lPrecioTotal;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.DateTimePicker dpFechaEntrega;
        private System.Windows.Forms.DateTimePicker dtFechaPedido;
        private System.Windows.Forms.DateTimePicker dtFechaRequerida;
        private System.Windows.Forms.ComboBox cbViasEnvio;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewComboBoxColumn nombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
    }
}