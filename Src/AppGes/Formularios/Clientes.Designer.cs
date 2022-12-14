using System;
using System.Windows.Forms;

namespace AppGes.Formularios
{
    partial class ClientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbName = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lbLocalidad = new System.Windows.Forms.Label();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.lbNif = new System.Windows.Forms.Label();
            this.lbCP = new System.Windows.Forms.Label();
            this.tbCP = new System.Windows.Forms.TextBox();
            this.tbNif = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.tbClienteId = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbObservaciones = new System.Windows.Forms.Label();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.bt_Limpiar = new System.Windows.Forms.Button();
            this.tx_Apellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Buscar = new System.Windows.Forms.Button();
            this.tx_Nombre = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.95811F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.04189F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 417F));
            this.tableLayoutPanel1.Controls.Add(this.lbName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbNombre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbApellidos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbApellidos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbEmail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbEmail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbTelefono, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbTelefono, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbLocalidad, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbLocalidad, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbDireccion, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbDireccion, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbNif, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbCP, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbCP, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbNif, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 79);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(906, 143);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(2, 0);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(58, 17);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(105, 2);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(277, 22);
            this.tbNombre.TabIndex = 3;
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Location = new System.Drawing.Point(2, 31);
            this.lbApellidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(65, 17);
            this.lbApellidos.TabIndex = 4;
            this.lbApellidos.Text = "Apellidos";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(105, 33);
            this.tbApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(277, 22);
            this.tbApellidos.TabIndex = 5;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(2, 62);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 17);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(105, 64);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(277, 22);
            this.tbEmail.TabIndex = 12;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(2, 94);
            this.lbTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(64, 17);
            this.lbTelefono.TabIndex = 8;
            this.lbTelefono.Text = "Telefono";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(105, 96);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(277, 22);
            this.tbTelefono.TabIndex = 10;
            // 
            // lbLocalidad
            // 
            this.lbLocalidad.AutoSize = true;
            this.lbLocalidad.Location = new System.Drawing.Point(386, 62);
            this.lbLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLocalidad.Name = "lbLocalidad";
            this.lbLocalidad.Size = new System.Drawing.Size(69, 17);
            this.lbLocalidad.TabIndex = 7;
            this.lbLocalidad.Text = "Localidad";
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Location = new System.Drawing.Point(490, 64);
            this.tbLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(400, 22);
            this.tbLocalidad.TabIndex = 1;
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(386, 31);
            this.lbDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(67, 17);
            this.lbDireccion.TabIndex = 6;
            this.lbDireccion.Text = "Dirección";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(490, 33);
            this.tbDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(400, 22);
            this.tbDireccion.TabIndex = 9;
            // 
            // lbNif
            // 
            this.lbNif.AutoSize = true;
            this.lbNif.Location = new System.Drawing.Point(386, 0);
            this.lbNif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNif.Name = "lbNif";
            this.lbNif.Size = new System.Drawing.Size(29, 17);
            this.lbNif.TabIndex = 13;
            this.lbNif.Text = "NIF";
            // 
            // lbCP
            // 
            this.lbCP.AutoSize = true;
            this.lbCP.Location = new System.Drawing.Point(386, 94);
            this.lbCP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCP.Name = "lbCP";
            this.lbCP.Size = new System.Drawing.Size(30, 17);
            this.lbCP.TabIndex = 14;
            this.lbCP.Text = "C.P";
            // 
            // tbCP
            // 
            this.tbCP.Location = new System.Drawing.Point(490, 96);
            this.tbCP.Margin = new System.Windows.Forms.Padding(2);
            this.tbCP.Name = "tbCP";
            this.tbCP.Size = new System.Drawing.Size(74, 22);
            this.tbCP.TabIndex = 16;
            // 
            // tbNif
            // 
            this.tbNif.Location = new System.Drawing.Point(490, 2);
            this.tbNif.Margin = new System.Windows.Forms.Padding(2);
            this.tbNif.Name = "tbNif";
            this.tbNif.Size = new System.Drawing.Size(74, 22);
            this.tbNif.TabIndex = 15;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(11, 46);
            this.lbId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(74, 17);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Cliente Nº:";
            this.lbId.UseMnemonic = false;
            // 
            // tbClienteId
            // 
            this.tbClienteId.Location = new System.Drawing.Point(116, 46);
            this.tbClienteId.Margin = new System.Windows.Forms.Padding(2);
            this.tbClienteId.Name = "tbClienteId";
            this.tbClienteId.Size = new System.Drawing.Size(64, 22);
            this.tbClienteId.TabIndex = 1;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellidos,
            this.NIF,
            this.Email,
            this.Telefono,
            this.Direccion,
            this.Localidad,
            this.CP});
            this.dgvClientes.Location = new System.Drawing.Point(12, 521);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowTemplate.Height = 31;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(960, 346);
            this.dgvClientes.TabIndex = 2;
            this.dgvClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentDoubleClick);
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 48;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 87;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 94;
            // 
            // NIF
            // 
            this.NIF.DataPropertyName = "NIF";
            this.NIF.HeaderText = "NIF";
            this.NIF.Name = "NIF";
            this.NIF.ReadOnly = true;
            this.NIF.Width = 58;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 71;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 93;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 96;
            // 
            // Localidad
            // 
            this.Localidad.DataPropertyName = "Localidad";
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            this.Localidad.Width = 98;
            // 
            // CP
            // 
            this.CP.DataPropertyName = "CP";
            this.CP.HeaderText = "CP";
            this.CP.Name = "CP";
            this.CP.ReadOnly = true;
            this.CP.Width = 55;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.06478F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.93523F));
            this.tableLayoutPanel3.Controls.Add(this.lbObservaciones, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbObservaciones, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(7, 239);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(906, 100);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // lbObservaciones
            // 
            this.lbObservaciones.AutoSize = true;
            this.lbObservaciones.Location = new System.Drawing.Point(2, 0);
            this.lbObservaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbObservaciones.Name = "lbObservaciones";
            this.lbObservaciones.Size = new System.Drawing.Size(103, 17);
            this.lbObservaciones.TabIndex = 0;
            this.lbObservaciones.Text = "Observaciones";
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Location = new System.Drawing.Point(111, 2);
            this.tbObservaciones.Margin = new System.Windows.Forms.Padding(2);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(793, 95);
            this.tbObservaciones.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1209, 26);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.salirToolStripMenuItem.Text = "Guardar";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.guardarToolStripMenuItem.Text = "Salir";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.cancelarToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            this.cancelarToolStripMenuItem.Click += new System.EventHandler(this.cancelarToolStripMenuItem_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Eliminar";
            this.dataGridViewImageColumn1.Width = 87;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Controls.Add(this.bt_Limpiar);
            this.panelBusqueda.Controls.Add(this.tx_Apellidos);
            this.panelBusqueda.Controls.Add(this.label2);
            this.panelBusqueda.Controls.Add(this.label1);
            this.panelBusqueda.Controls.Add(this.bt_Buscar);
            this.panelBusqueda.Controls.Add(this.tx_Nombre);
            this.panelBusqueda.Location = new System.Drawing.Point(14, 372);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(295, 133);
            this.panelBusqueda.TabIndex = 10;
            // 
            // bt_Limpiar
            // 
            this.bt_Limpiar.Enabled = false;
            this.bt_Limpiar.Location = new System.Drawing.Point(127, 87);
            this.bt_Limpiar.Name = "bt_Limpiar";
            this.bt_Limpiar.Size = new System.Drawing.Size(82, 31);
            this.bt_Limpiar.TabIndex = 12;
            this.bt_Limpiar.Text = "Limpiar";
            this.bt_Limpiar.UseVisualStyleBackColor = true;
            this.bt_Limpiar.Click += new System.EventHandler(this.bt_Limpiar_Click);
            // 
            // tx_Apellidos
            // 
            this.tx_Apellidos.Location = new System.Drawing.Point(97, 47);
            this.tx_Apellidos.Name = "tx_Apellidos";
            this.tx_Apellidos.Size = new System.Drawing.Size(185, 22);
            this.tx_Apellidos.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // bt_Buscar
            // 
            this.bt_Buscar.Location = new System.Drawing.Point(19, 87);
            this.bt_Buscar.Name = "bt_Buscar";
            this.bt_Buscar.Size = new System.Drawing.Size(86, 31);
            this.bt_Buscar.TabIndex = 7;
            this.bt_Buscar.Text = "Filtrar";
            this.bt_Buscar.UseVisualStyleBackColor = true;
            this.bt_Buscar.Click += new System.EventHandler(this.bt_Buscar_Click);
            // 
            // tx_Nombre
            // 
            this.tx_Nombre.Location = new System.Drawing.Point(97, 16);
            this.tx_Nombre.Name = "tx_Nombre";
            this.tx_Nombre.Size = new System.Drawing.Size(185, 22);
            this.tx_Nombre.TabIndex = 8;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 878);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbClienteId);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientesForm";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        





        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbClienteId;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbLocalidad;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbLocalidad;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lbNif;
        private System.Windows.Forms.Label lbCP;
        private System.Windows.Forms.TextBox tbCP;
        private System.Windows.Forms.TextBox tbNif;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbObservaciones;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn NIF;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Localidad;
        private DataGridViewTextBoxColumn CP;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem cancelarToolStripMenuItem;
        private Panel panelBusqueda;
        private Button bt_Limpiar;
        private TextBox tx_Apellidos;
        private Label label2;
        private Label label1;
        private Button bt_Buscar;
        private TextBox tx_Nombre;
    }
}