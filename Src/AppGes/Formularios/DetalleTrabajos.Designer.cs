namespace AppGes.Formularios
{
    partial class DetalleTrabajos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arvhivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbName = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.lbNif = new System.Windows.Forms.Label();
            this.tbNif = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.tbClientId = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnFac = new System.Windows.Forms.Panel();
            this.panelFacturas = new System.Windows.Forms.Panel();
            this.tbNumeroFactura = new System.Windows.Forms.TextBox();
            this.btGuardarFac = new System.Windows.Forms.Button();
            this.btEliminarFac = new System.Windows.Forms.Button();
            this.btEditarFac = new System.Windows.Forms.Button();
            this.btNuevaFac = new System.Windows.Forms.Button();
            this.tbResto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbCuenta = new System.Windows.Forms.TextBox();
            this.lbFac = new System.Windows.Forms.Label();
            this.chkFinalizado = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbFacturas = new System.Windows.Forms.Label();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFechaReal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPresupuesto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.lbObser = new System.Windows.Forms.Label();
            this.lbFacId = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnFac.SuspendLayout();
            this.panelFacturas.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arvhivoToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1802, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arvhivoToolStripMenuItem
            // 
            this.arvhivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.arvhivoToolStripMenuItem.Name = "arvhivoToolStripMenuItem";
            this.arvhivoToolStripMenuItem.Size = new System.Drawing.Size(95, 34);
            this.arvhivoToolStripMenuItem.Text = "Archivo";
            this.arvhivoToolStripMenuItem.Click += new System.EventHandler(this.arvhivoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(178, 34);
            this.salirToolStripMenuItem.Text = "Guardar";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(178, 34);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(112, 34);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.clientesToolStripMenuItem.Text = "Editar";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(14, 102);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(81, 25);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(142, 102);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(392, 29);
            this.tbNombre.TabIndex = 3;
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Location = new System.Drawing.Point(14, 148);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(92, 25);
            this.lbApellidos.TabIndex = 4;
            this.lbApellidos.Text = "Apellidos";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(142, 148);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(392, 29);
            this.tbApellidos.TabIndex = 5;
            // 
            // lbNif
            // 
            this.lbNif.AutoSize = true;
            this.lbNif.Location = new System.Drawing.Point(370, 66);
            this.lbNif.Name = "lbNif";
            this.lbNif.Size = new System.Drawing.Size(43, 25);
            this.lbNif.TabIndex = 13;
            this.lbNif.Text = "NIF";
            // 
            // tbNif
            // 
            this.tbNif.Location = new System.Drawing.Point(434, 63);
            this.tbNif.Name = "tbNif";
            this.tbNif.Size = new System.Drawing.Size(100, 29);
            this.tbNif.TabIndex = 15;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(14, 63);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(105, 25);
            this.lbId.TabIndex = 3;
            this.lbId.Text = "Cliente Nº:";
            this.lbId.UseMnemonic = false;
            // 
            // tbClientId
            // 
            this.tbClientId.Location = new System.Drawing.Point(142, 63);
            this.tbClientId.Name = "tbClientId";
            this.tbClientId.Size = new System.Drawing.Size(86, 29);
            this.tbClientId.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppGes.Properties.Resources.lupa;
            this.pictureBox1.InitialImage = global::AppGes.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(197, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbId);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tbNif);
            this.panel1.Controls.Add(this.lbApellidos);
            this.panel1.Controls.Add(this.lbNif);
            this.panel1.Controls.Add(this.tbNombre);
            this.panel1.Controls.Add(this.tbClientId);
            this.panel1.Controls.Add(this.tbApellidos);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Location = new System.Drawing.Point(24, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 207);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Datos del Cliente";
            // 
            // pnFac
            // 
            this.pnFac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFac.Controls.Add(this.panelFacturas);
            this.pnFac.Controls.Add(this.chkFinalizado);
            this.pnFac.Controls.Add(this.panel3);
            this.pnFac.Controls.Add(this.dtpFechaReal);
            this.pnFac.Controls.Add(this.dtpFechaEntrega);
            this.pnFac.Controls.Add(this.dtpFechaEntrada);
            this.pnFac.Controls.Add(this.label6);
            this.pnFac.Controls.Add(this.label5);
            this.pnFac.Controls.Add(this.label4);
            this.pnFac.Controls.Add(this.tbPresupuesto);
            this.pnFac.Controls.Add(this.label2);
            this.pnFac.Location = new System.Drawing.Point(24, 275);
            this.pnFac.Name = "pnFac";
            this.pnFac.Size = new System.Drawing.Size(1319, 642);
            this.pnFac.TabIndex = 18;
            // 
            // panelFacturas
            // 
            this.panelFacturas.Controls.Add(this.lbFacId);
            this.panelFacturas.Controls.Add(this.tbNumeroFactura);
            this.panelFacturas.Controls.Add(this.btGuardarFac);
            this.panelFacturas.Controls.Add(this.btEliminarFac);
            this.panelFacturas.Controls.Add(this.btEditarFac);
            this.panelFacturas.Controls.Add(this.btNuevaFac);
            this.panelFacturas.Controls.Add(this.tbResto);
            this.panelFacturas.Controls.Add(this.label3);
            this.panelFacturas.Controls.Add(this.label8);
            this.panelFacturas.Controls.Add(this.label7);
            this.panelFacturas.Controls.Add(this.tbTotal);
            this.panelFacturas.Controls.Add(this.tbCuenta);
            this.panelFacturas.Controls.Add(this.lbFac);
            this.panelFacturas.Location = new System.Drawing.Point(454, 24);
            this.panelFacturas.Name = "panelFacturas";
            this.panelFacturas.Size = new System.Drawing.Size(475, 231);
            this.panelFacturas.TabIndex = 15;
            // 
            // tbNumeroFactura
            // 
            this.tbNumeroFactura.Enabled = false;
            this.tbNumeroFactura.Location = new System.Drawing.Point(140, 8);
            this.tbNumeroFactura.Name = "tbNumeroFactura";
            this.tbNumeroFactura.Size = new System.Drawing.Size(294, 29);
            this.tbNumeroFactura.TabIndex = 13;
            this.tbNumeroFactura.TextChanged += new System.EventHandler(this.tbNumeroFactura_TextChanged);
            // 
            // btGuardarFac
            // 
            this.btGuardarFac.Location = new System.Drawing.Point(348, 184);
            this.btGuardarFac.Name = "btGuardarFac";
            this.btGuardarFac.Size = new System.Drawing.Size(99, 41);
            this.btGuardarFac.TabIndex = 12;
            this.btGuardarFac.Text = "Guardar";
            this.btGuardarFac.UseVisualStyleBackColor = true;
            this.btGuardarFac.Click += new System.EventHandler(this.btGuardarFac_Click);
            // 
            // btEliminarFac
            // 
            this.btEliminarFac.Location = new System.Drawing.Point(233, 184);
            this.btEliminarFac.Name = "btEliminarFac";
            this.btEliminarFac.Size = new System.Drawing.Size(109, 41);
            this.btEliminarFac.TabIndex = 11;
            this.btEliminarFac.Text = "Eliminar";
            this.btEliminarFac.UseVisualStyleBackColor = true;
            this.btEliminarFac.Click += new System.EventHandler(this.btEliminarFac_Click);
            // 
            // btEditarFac
            // 
            this.btEditarFac.Location = new System.Drawing.Point(118, 184);
            this.btEditarFac.Name = "btEditarFac";
            this.btEditarFac.Size = new System.Drawing.Size(109, 41);
            this.btEditarFac.TabIndex = 10;
            this.btEditarFac.Text = "Editar";
            this.btEditarFac.UseVisualStyleBackColor = true;
            this.btEditarFac.Click += new System.EventHandler(this.btEditarFac_Click);
            // 
            // btNuevaFac
            // 
            this.btNuevaFac.Location = new System.Drawing.Point(3, 184);
            this.btNuevaFac.Name = "btNuevaFac";
            this.btNuevaFac.Size = new System.Drawing.Size(109, 41);
            this.btNuevaFac.TabIndex = 9;
            this.btNuevaFac.Text = "Nuevo";
            this.btNuevaFac.UseVisualStyleBackColor = true;
            this.btNuevaFac.Click += new System.EventHandler(this.btNuevaFac_Click);
            // 
            // tbResto
            // 
            this.tbResto.Enabled = false;
            this.tbResto.Location = new System.Drawing.Point(140, 137);
            this.tbResto.Name = "tbResto";
            this.tbResto.Size = new System.Drawing.Size(294, 29);
            this.tbResto.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "A Cuenta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(140, 51);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(294, 29);
            this.tbTotal.TabIndex = 3;
            this.tbTotal.TextChanged += new System.EventHandler(this.tbTotal_TextChanged);
            // 
            // tbCuenta
            // 
            this.tbCuenta.Enabled = false;
            this.tbCuenta.Location = new System.Drawing.Point(140, 97);
            this.tbCuenta.Name = "tbCuenta";
            this.tbCuenta.Size = new System.Drawing.Size(294, 29);
            this.tbCuenta.TabIndex = 1;
            this.tbCuenta.TextChanged += new System.EventHandler(this.tbCuenta_TextChanged);
            // 
            // lbFac
            // 
            this.lbFac.AutoSize = true;
            this.lbFac.Location = new System.Drawing.Point(19, 8);
            this.lbFac.Name = "lbFac";
            this.lbFac.Size = new System.Drawing.Size(115, 25);
            this.lbFac.TabIndex = 0;
            this.lbFac.Text = "Factura Nº :";
            // 
            // chkFinalizado
            // 
            this.chkFinalizado.AutoSize = true;
            this.chkFinalizado.Location = new System.Drawing.Point(178, 247);
            this.chkFinalizado.Name = "chkFinalizado";
            this.chkFinalizado.Size = new System.Drawing.Size(127, 29);
            this.chkFinalizado.TabIndex = 14;
            this.chkFinalizado.Text = "Finalizado";
            this.chkFinalizado.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbFacturas);
            this.panel3.Controls.Add(this.dgvFacturas);
            this.panel3.Location = new System.Drawing.Point(19, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1130, 298);
            this.panel3.TabIndex = 13;
            // 
            // lbFacturas
            // 
            this.lbFacturas.AutoSize = true;
            this.lbFacturas.Location = new System.Drawing.Point(3, 0);
            this.lbFacturas.Name = "lbFacturas";
            this.lbFacturas.Size = new System.Drawing.Size(88, 25);
            this.lbFacturas.TabIndex = 13;
            this.lbFacturas.Text = "Facturas";
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToResizeColumns = false;
            this.dgvFacturas.AllowUserToResizeRows = false;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nFactura,
            this.Total,
            this.Cuenta,
            this.Resto});
            this.dgvFacturas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvFacturas.Location = new System.Drawing.Point(0, 62);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowTemplate.Height = 31;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(1122, 221);
            this.dgvFacturas.TabIndex = 12;
            this.dgvFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturas_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nFactura
            // 
            this.nFactura.DataPropertyName = "NFactura";
            this.nFactura.HeaderText = "Nª Factura";
            this.nFactura.Name = "nFactura";
            this.nFactura.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Importe";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Cuenta
            // 
            this.Cuenta.DataPropertyName = "Cuenta";
            this.Cuenta.HeaderText = "A Cuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ReadOnly = true;
            // 
            // Resto
            // 
            this.Resto.DataPropertyName = "Pendiente";
            this.Resto.HeaderText = "Resto";
            this.Resto.Name = "Resto";
            this.Resto.ReadOnly = true;
            // 
            // dtpFechaReal
            // 
            this.dtpFechaReal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReal.Location = new System.Drawing.Point(178, 190);
            this.dtpFechaReal.Name = "dtpFechaReal";
            this.dtpFechaReal.Size = new System.Drawing.Size(200, 29);
            this.dtpFechaReal.TabIndex = 11;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(178, 79);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(200, 29);
            this.dtpFechaEntrega.TabIndex = 10;
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrada.Location = new System.Drawing.Point(178, 133);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(200, 29);
            this.dtpFechaEntrada.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha Real";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha Entrega";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Entrada";
            // 
            // tbPresupuesto
            // 
            this.tbPresupuesto.Location = new System.Drawing.Point(178, 24);
            this.tbPresupuesto.Name = "tbPresupuesto";
            this.tbPresupuesto.Size = new System.Drawing.Size(200, 29);
            this.tbPresupuesto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nº Presupuesto";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tbObservaciones);
            this.panel4.Controls.Add(this.lbObser);
            this.panel4.Location = new System.Drawing.Point(616, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(727, 207);
            this.panel4.TabIndex = 19;
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Location = new System.Drawing.Point(7, 46);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(707, 148);
            this.tbObservaciones.TabIndex = 1;
            // 
            // lbObser
            // 
            this.lbObser.AutoSize = true;
            this.lbObser.Location = new System.Drawing.Point(4, 4);
            this.lbObser.Name = "lbObser";
            this.lbObser.Size = new System.Drawing.Size(144, 25);
            this.lbObser.TabIndex = 0;
            this.lbObser.Text = "Observaciones";
            // 
            // lbFacId
            // 
            this.lbFacId.AutoSize = true;
            this.lbFacId.Location = new System.Drawing.Point(50, 69);
            this.lbFacId.Name = "lbFacId";
            this.lbFacId.Size = new System.Drawing.Size(64, 25);
            this.lbFacId.TabIndex = 14;
            this.lbFacId.Text = "label9";
            this.lbFacId.Visible = false;
            // 
            // DetalleTrabajos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1802, 962);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnFac);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DetalleTrabajos";
            this.Text = "AddTrabajos";
            this.Load += new System.EventHandler(this.AddTrabajos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnFac.ResumeLayout(false);
            this.pnFac.PerformLayout();
            this.panelFacturas.ResumeLayout(false);
            this.panelFacturas.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arvhivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Label lbNif;
        private System.Windows.Forms.TextBox tbNif;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbClientId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnFac;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbFacturas;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.DateTimePicker dtpFechaReal;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPresupuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.Label lbObser;
        private System.Windows.Forms.CheckBox chkFinalizado;
        private System.Windows.Forms.Panel panelFacturas;
        private System.Windows.Forms.Button btEliminarFac;
        private System.Windows.Forms.Button btEditarFac;
        private System.Windows.Forms.Button btNuevaFac;
        private System.Windows.Forms.TextBox tbResto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbCuenta;
        private System.Windows.Forms.Label lbFac;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resto;
        private System.Windows.Forms.Button btGuardarFac;
        private System.Windows.Forms.TextBox tbNumeroFactura;
        private System.Windows.Forms.Label lbFacId;
    }
}