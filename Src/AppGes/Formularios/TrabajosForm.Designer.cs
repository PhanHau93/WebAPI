using System;
using System.Windows.Forms;

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
            this.bt_Buscar = new System.Windows.Forms.Button();
            this.tx_Nombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Limpiar = new System.Windows.Forms.Button();
            this.tx_Apellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTrabajos
            // 
            this.dgvTrabajos.AllowUserToAddRows = false;
            this.dgvTrabajos.AllowUserToDeleteRows = false;
            this.dgvTrabajos.AllowUserToOrderColumns = true;
            this.dgvTrabajos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvTrabajos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
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
            this.dgvTrabajos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTrabajos.Location = new System.Drawing.Point(0, 189);
            this.dgvTrabajos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTrabajos.MultiSelect = false;
            this.dgvTrabajos.Name = "dgvTrabajos";
            this.dgvTrabajos.ReadOnly = true;
            this.dgvTrabajos.RowTemplate.Height = 31;
            this.dgvTrabajos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrabajos.Size = new System.Drawing.Size(1240, 443);
            this.dgvTrabajos.TabIndex = 0;
            this.dgvTrabajos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrabajos_CellContentDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 48;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 87;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Width = 94;
            // 
            // Fecha_Entrada
            // 
            this.Fecha_Entrada.DataPropertyName = "Presupuesto";
            this.Fecha_Entrada.HeaderText = "Presupuesto";
            this.Fecha_Entrada.Name = "Fecha_Entrada";
            this.Fecha_Entrada.Width = 117;
            // 
            // fechaEntrada
            // 
            this.fechaEntrada.DataPropertyName = "FechaEntrada";
            this.fechaEntrada.HeaderText = "Fecha Entrada";
            this.fechaEntrada.Name = "fechaEntrada";
            this.fechaEntrada.Width = 130;
            // 
            // fechaSalida
            // 
            this.fechaSalida.DataPropertyName = "FechaEntrega";
            this.fechaSalida.HeaderText = "Fecha Entrega";
            this.fechaSalida.Name = "fechaSalida";
            this.fechaSalida.Width = 130;
            // 
            // importeTotal
            // 
            this.importeTotal.DataPropertyName = "Total";
            this.importeTotal.HeaderText = "Total";
            this.importeTotal.Name = "importeTotal";
            this.importeTotal.Width = 69;
            // 
            // Cuenta
            // 
            this.Cuenta.DataPropertyName = "Cuenta";
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cuenta.Width = 59;
            // 
            // pendiente
            // 
            this.pendiente.DataPropertyName = "Pendiente";
            this.pendiente.HeaderText = "Pendiente";
            this.pendiente.Name = "pendiente";
            this.pendiente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pendiente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pendiente.Width = 78;
            // 
            // Finalizado
            // 
            this.Finalizado.DataPropertyName = "Finalizado";
            this.Finalizado.HeaderText = "Finalizado";
            this.Finalizado.Name = "Finalizado";
            this.Finalizado.Width = 78;
            // 
            // nFactura
            // 
            this.nFactura.DataPropertyName = "Factura";
            this.nFactura.HeaderText = "Factura";
            this.nFactura.Name = "nFactura";
            this.nFactura.Width = 85;
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1227, 26);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.salirToolStripMenuItem.Text = "Salir ";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
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
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.añadirToolStripMenuItem.Text = "Añadir";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.añadirToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Limpiar);
            this.panel1.Controls.Add(this.tx_Apellidos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bt_Buscar);
            this.panel1.Controls.Add(this.tx_Nombre);
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 133);
            this.panel1.TabIndex = 9;
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
            // TrabajosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvTrabajos);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TrabajosForm";
            this.Text = "Trabajos";
            this.Load += new System.EventHandler(this.TrabajosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.Windows.Forms.DataGridView dgvTrabajos;
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
        private Button bt_Buscar;
        private TextBox tx_Nombre;
        private Panel panel1;
        private TextBox tx_Apellidos;
        private Label label2;
        private Label label1;
        private Button bt_Limpiar;
    }
}