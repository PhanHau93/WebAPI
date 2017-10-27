using AppGes.Enumerados;
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
    public partial class AddTrabajos : Form
    {
        private int ModoApertura { get; set; }
        public AddTrabajos() //Nuevo
        {
            //this.ModoApertura = Convert.ToInt32(Modo.nuevo);
            InitializeComponent();
        }
        public AddTrabajos(int id, bool consulta)
        {
            this.ModoApertura = consulta ? Convert.ToInt32(Modo.consulta) : Convert.ToInt32(Modo.edicion);
            InitializeComponent();
        }
        private void AddTrabajos_Load(object sender, EventArgs e)
        {
            this.Width = 725;
            this.Height = 500;
        }

        private void arvhivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm(-1, false);
            clientesForm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm(-1, false);
            clientesForm.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Preguntar por cambios            
            this.Close();
        }
    }
}
