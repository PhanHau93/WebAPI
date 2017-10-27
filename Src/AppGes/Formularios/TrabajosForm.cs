using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGes.Formularios
{
    public partial class TrabajosForm : Form
    {
        public TrabajosForm()
        {
            InitializeComponent();
        }      

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm();
            clientesForm.Show();
        }       

        private void TrabajosForm_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTrabajos addTrabajos = new AddTrabajos();
            addTrabajos.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 0;
            AddTrabajos addTrabajos = new AddTrabajos(id ,true);
            addTrabajos.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 0;
            AddTrabajos addTrabajos = new AddTrabajos(id, false);
            
            addTrabajos.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();            
        }
    }
}
