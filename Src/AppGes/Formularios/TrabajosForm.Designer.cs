namespace AppGes.Formularios
{
    partial class TrabajosForm
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
            this.btImprimir = new System.Windows.Forms.Button();
            this.dgvTrabajos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finalizado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btImprimir
            // 
            this.btImprimir.Enabled = false;
            this.btImprimir.Location = new System.Drawing.Point(637, 181);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(118, 52);
            this.btImprimir.TabIndex = 1;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            // 
            // dgvTrabajos
            // 
            this.dgvTrabajos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvTrabajos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellidos,
            this.Fecha_Entrada,
            this.fechaEntrada,
            this.fechaSalida,
            this.importeTotal,
            this.Cuenta,
            this.pendiente,
            this.Finalizado,
            this.nFactura});
            this.dgvTrabajos.Location = new System.Drawing.Point(0, 120);
            this.dgvTrabajos.MultiSelect = false;
            this.dgvTrabajos.Name = "dgvTrabajos";
            this.dgvTrabajos.ReadOnly = true;
            this.dgvTrabajos.RowTemplate.Height = 31;
            this.dgvTrabajos.Size = new System.Drawing.Size(1705, 665);
            this.dgvTrabajos.TabIndex = 0;
            this.dgvTrabajos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrabajos_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 69;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 122;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 133;
            // 
            // Fecha_Entrada
            // 
            this.Fecha_Entrada.HeaderText = "Presupuesto";
            this.Fecha_Entrada.Name = "Fecha_Entrada";
            this.Fecha_Entrada.ReadOnly = true;
            this.Fecha_Entrada.Width = 163;
            // 
            // fechaEntrada
            // 
            this.fechaEntrada.HeaderText = "Fecha Entrada";
            this.fechaEntrada.Name = "fechaEntrada";
            this.fechaEntrada.ReadOnly = true;
            this.fechaEntrada.Width = 181;
            // 
            // fechaSalida
            // 
            this.fechaSalida.HeaderText = "Fecha Salida";
            this.fechaSalida.Name = "fechaSalida";
            this.fechaSalida.ReadOnly = true;
            this.fechaSalida.Width = 168;
            // 
            // importeTotal
            // 
            this.importeTotal.HeaderText = "Total";
            this.importeTotal.Name = "importeTotal";
            this.importeTotal.ReadOnly = true;
            this.importeTotal.Width = 97;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ReadOnly = true;
            this.Cuenta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cuenta.Width = 82;
            // 
            // pendiente
            // 
            this.pendiente.HeaderText = "Pendiente";
            this.pendiente.Name = "pendiente";
            this.pendiente.ReadOnly = true;
            this.pendiente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pendiente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pendiente.Width = 106;
            // 
            // Finalizado
            // 
            this.Finalizado.HeaderText = "Finalizado";
            this.Finalizado.Name = "Finalizado";
            this.Finalizado.ReadOnly = true;
            this.Finalizado.Width = 107;
            // 
            // nFactura
            // 
            this.nFactura.HeaderText = "Factura";
            this.nFactura.Name = "nFactura";
            this.nFactura.ReadOnly = true;
            this.nFactura.Width = 119;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.gestionToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1687, 38);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(95, 34);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(149, 34);
            this.salirToolStripMenuItem.Text = "Salir ";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(95, 34);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.añadirToolStripMenuItem.Text = "Añadir";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.añadirToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(107, 34);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // TrabajosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 701);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvTrabajos);
            this.Controls.Add(this.btImprimir);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrabajosForm";
            this.Text = "Trabajos";
            this.Load += new System.EventHandler(this.TrabajosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTrabajos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendiente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Finalizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFactura;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}