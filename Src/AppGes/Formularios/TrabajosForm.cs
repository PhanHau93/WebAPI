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
        private ITrabajos _servicioTrabajos = new AppGes.Services.TrabajosService();
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
            if (addTrabajos.facturaModificada)
            {
                CargarGridTrabajos();
            }
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
                    if (addTrabajos.facturaModificada)
                    {
                        CargarGridTrabajos();
                    }
                }
            }


        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var row = dgvTrabajos.SelectedRows;
            if (row != null && row.Count > 0)
            {
                var id = row[0].Cells[0].Value;
                if (id != null)
                {


                    DetalleTrabajos addTrabajos = new DetalleTrabajos(Convert.ToInt32(id), false);

                    addTrabajos.ShowDialog();

                    if (addTrabajos.facturaModificada)
                        CargarGridTrabajos();
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTrabajos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirTrabajoPorId();
        }

        private void bt_Buscar_Click(object sender, EventArgs e)
        {
            int header = 0;
            string filtro = string.Empty;

            if (string.IsNullOrEmpty(tx_Apellidos.Text) && string.IsNullOrEmpty(tx_Nombre.Text))
                return;
            if (string.IsNullOrEmpty(tx_Apellidos.Text))
            {
                header = 1;
                filtro = tx_Nombre.Text;
            }
            else if (string.IsNullOrEmpty(tx_Nombre.Text))
            {
                header = 2;
                filtro = tx_Apellidos.Text;
            }

            for (int u = 0; u < dgvTrabajos.RowCount; u++)
            {
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvTrabajos.DataSource];
                currencyManager1.SuspendBinding();
                if (header > 0)
                {
                    if (dgvTrabajos.Rows[u].Cells[header].Value.ToString().Contains(filtro))
                    {
                        dgvTrabajos.Rows[u].Visible = true;
                    }
                    else
                    {
                        dgvTrabajos.Rows[u].Visible = false;
                    }
                }
                else
                {
                    if (dgvTrabajos.Rows[u].Cells[2].Value.ToString().Contains(tx_Apellidos.Text) &&
                        dgvTrabajos.Rows[u].Cells[1].Value.ToString().Contains(tx_Nombre.Text))
                    {
                        dgvTrabajos.Rows[u].Visible = true;
                    }
                    else
                    {
                        dgvTrabajos.Rows[u].Visible = false;
                    }
                }
                currencyManager1.ResumeBinding();
            }

            bt_Limpiar.Enabled = true;





        }

        private void bt_Limpiar_Click(object sender, EventArgs e)
        {

            for (int u = 0; u < dgvTrabajos.RowCount; u++)
            {
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvTrabajos.DataSource];
                currencyManager1.SuspendBinding();

                dgvTrabajos.Rows[u].Visible = true;

                currencyManager1.ResumeBinding();
            }
            tx_Apellidos.Text = "";
            tx_Nombre.Text = "";
            bt_Limpiar.Enabled = false;
        }
    }
}
