using AppGes.Fake;
using AppGes.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGes.Models;

namespace AppGes.Formularios
{
    public partial class TrabajosForm : Form
    {
        private ITrabajos _servicioTrabajos = new TrabajosFake();
        public TrabajosForm()
        {
            InitializeComponent();

            CargarGridTrabajos();
        }

        private void CargarGridTrabajos()
        {
           var trabajos = _servicioTrabajos.Get();
            dgvTrabajos.DataSource = ConvertirListado(trabajos);

        }

        private object ConvertirListado(IEnumerable<TrabajoItem> trabajos)
        {
            List<TrabajosSource> source = new List<TrabajosSource>();
            if (trabajos.Count() > 0)
            {               
                foreach (TrabajoItem item in trabajos)
                {
                    source.Add(TrabajosSource.convertToItem(item));
                }
            }

            return source;
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
            DetalleTrabajos addTrabajos = new DetalleTrabajos();
            addTrabajos.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirTrabajoPorId();
        }

        private void AbrirTrabajoPorId()
        {
            var row = dgvTrabajos.SelectedRows;
            if (row != null && row.Count > 0)
            {
                var id = row[0].Cells[0].Value;
                if (id != null)
                {
                    DetalleTrabajos addTrabajos = new DetalleTrabajos(Convert.ToInt32(id), true);
                    addTrabajos.ShowDialog();
                }
            }

           
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 0;
            DetalleTrabajos addTrabajos = new DetalleTrabajos(id, false);
            
            addTrabajos.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void dgvTrabajos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirTrabajoPorId();
        }
    }
}
