using AppGes.Enumerados;
using AppGes.Fake;
using AppGes.Interfaces;
using AppGes.Models;
using AppGes.Utils;
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
    public partial class DetalleTrabajos : Form
    {
        private int ModoApertura { get; set; }
        private int ModoFactura { get; set; }
        private Utilidades utils = new Utilidades();
        private ITrabajos _servicioTrabajo = new TrabajosFake();
        private TrabajoItem _item;

       
        public DetalleTrabajos() //Nuevo
        {
            //this.ModoApertura = Convert.ToInt32(Modo.nuevo);
            InitializeComponent();

            this.Width = 1000;
            this.Height = 500;
        }
        public DetalleTrabajos(int id, bool consulta)
        {
            this.ModoApertura = consulta ? Convert.ToInt32(Modo.consulta) : Convert.ToInt32(Modo.edicion);
            this.ModoFactura = Modo.consulta;
            InitializeComponent();

            if (this.ModoApertura.Equals(Modo.consulta))
            {
                CargaModoConsulta(id);
            }
            

        }

        private void CargaModoConsulta(int id)
        {
            utils.HabilitarDeshabilitarTextBox(this.Controls, false);            
            CargarDatosPorId(id);
            panelFacturas.Enabled = false;
        }

        private void CargarDatosPorId(int id)
        {
            var trabajo = _servicioTrabajo.Get(id);
            if (trabajo != null)
            {
                tbApellidos.Text = trabajo.Cliente.Apellidos;
                tbClientId.Text = trabajo.Cliente.Id.ToString();
                tbNombre.Text = trabajo.Cliente.Nombre;
                tbNif.Text = trabajo.Cliente.NIF;
                tbPresupuesto.Text = trabajo.NPresupuesto.ToString();
                chkFinalizado.Checked = trabajo.Finalizado;

                if (trabajo.FechaEntrada.HasValue)
                    dtpFechaEntrada.Value = trabajo.FechaEntrada.Value;
                else
                    dtpFechaEntrada.Visible = false;

                if (trabajo.FechaEntrega.HasValue)
                    dtpFechaEntrega.Value = trabajo.FechaEntrega.Value;
                else
                    dtpFechaEntrega.Visible = false;

                if (trabajo.FechaReal.HasValue)
                    dtpFechaReal.Value = trabajo.FechaReal.Value;
                else
                    dtpFechaReal.Visible = false;

                tbObservaciones.Text = trabajo.Observaciones;

                this._item = trabajo;

                if (trabajo.Facturas != null)
                {
                    dgvFacturas.DataSource = trabajo.Facturas;
                    LimpiarSelecionGridFacturas();
                }

                FacturasChanged();

              
            }


        }

        private void AddTrabajos_Load(object sender, EventArgs e)
        {
            this.Width = 800;
            this.Height = 500;
            panelFacturas.BorderStyle = BorderStyle.FixedSingle;
            
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
            EditarTrabajo();
        }

        private void EditarTrabajo()
        {
            bool editar = true;
            if (chkFinalizado.Checked)
            {
                DialogResult dr = MessageBox.Show("El trabajo está Finalizado, ¿Desea continuar?", "", MessageBoxButtons.OKCancel);
                if (dr.Equals(DialogResult.Cancel))
                {
                    editar = false;
                }
            }

            if (editar)
            {
                this.ModoApertura = Modo.edicion;
                utils.HabilitarDeshabilitarTextBox(this.Controls, true);
                dtpFechaEntrada.Visible = true;
                dtpFechaEntrega.Visible = true;
                dtpFechaReal.Visible = true;
                dgvFacturas.Enabled = true;
                panelFacturas.Enabled = true;
            }
            
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Preguntar por cambios            
            this.Close();
        }

        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FacturasChanged();
        }

        private void FacturasChanged()
        {
            var row = dgvFacturas.SelectedRows;
            if (row != null && row.Count > 0)
            {
                var id = row[0].Cells[0].Value;
                if (id != null)
                {
                    lbFac.Text = "Factura Nº ";
                    tbNumeroFactura.Text = row[0].Cells[4].Value.ToString();
                    tbTotal.Text = row[0].Cells[1].Value.ToString();
                    tbCuenta.Text = row[0].Cells[2].Value.ToString();
                    tbResto.Text = (Convert.ToDecimal(tbTotal.Text) - Convert.ToDecimal(tbCuenta.Text)).ToString();
                }
            }
            else
            {
                lbFac.Text = "Factura Nº ";
                tbNumeroFactura.Text = string.Empty;
                tbTotal.Text = string.Empty;
                tbCuenta.Text = string.Empty;
                tbResto.Text = string.Empty;
            }
        }

        private void btNuevaFac_Click(object sender, EventArgs e)
        {
            this.ModoFactura = Modo.nuevo;

            btEditarFac.Enabled = false;
            btEliminarFac.Enabled = false;
            btGuardarFac.Enabled = true;
            
            tbCuenta.Text = string.Empty;
            tbCuenta.Enabled = true;
            tbTotal.Text = string.Empty;
            tbTotal.Enabled = true;
            tbNumeroFactura.Enabled = true;
            tbNumeroFactura.Text = string.Empty;
            tbResto.Text = string.Empty;

            
        }

        private void btEditarFac_Click(object sender, EventArgs e)
        {
            this.ModoFactura = Modo.edicion;
            btNuevaFac.Enabled = false;
            btEliminarFac.Enabled = false;
            btGuardarFac.Enabled = true;
            tbCuenta.Enabled = true;
            tbTotal.Enabled = true;
            tbNumeroFactura.Enabled = true;          

        }

        private void btEliminarFac_Click(object sender, EventArgs e)
        {

            var row = dgvFacturas.SelectedRows;
            if (row != null && row.Count > 0)
            {
                var id = row[0].Cells[0].Value;
                if (id != null)
                {
                    var facturaEliminar = this._item.Facturas.Where(x => x.id.Equals(id)).FirstOrDefault();
                    _item.Facturas.Remove(facturaEliminar);
                    if (_item.Facturas.Count > 0)
                        dgvFacturas.DataSource = _item.Facturas;
                    else
                        dgvFacturas.DataSource = null;

                    LimpiarSelecionGridFacturas();
                    FacturasChanged();
                }
            }
        }

        private void LimpiarSelecionGridFacturas()
        {
            dgvFacturas.ClearSelection();
            if (_item.Facturas.Count > 0)
                dgvFacturas.Rows[0].Selected = true;
        }

        private void tbNumeroFactura_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNumeroFactura.Text))
            {
                int res;
                if (!Int32.TryParse(tbNumeroFactura.Text, out res))
                {
                    MessageBox.Show("Introduzca Números");
                    //tbNumeroFactura.Text = string.Empty;
                    tbNumeroFactura.Focus();
                }
            }

        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbTotal.Text))
            {
                decimal res;
                if (!decimal.TryParse(tbTotal.Text, out res))
                {
                    MessageBox.Show("Introduzca Números");
                    //tbTotal.Text = string.Empty;
                    tbTotal.Focus();
                }
                else
                {
                    CalculaResto();
                }
            }
        }

        private void CalculaResto()
        {
            decimal importe;
            decimal cuenta;
            decimal resto;

            if (decimal.TryParse(tbTotal.Text, out importe) && decimal.TryParse(tbCuenta.Text, out cuenta))
                resto = importe - cuenta;
            else
                resto = 0;

            tbResto.Text = resto.ToString();
        }

        private void tbCuenta_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCuenta.Text))
            {
                decimal res;
                if (!decimal.TryParse(tbCuenta.Text, out res))
                {
                    MessageBox.Show("Introduzca Números");
                    //tbCuenta.Text = string.Empty;
                    tbCuenta.Focus();
                }
                else
                {
                    CalculaResto();
                }
            }
        }

        private void btGuardarFac_Click(object sender, EventArgs e)
        {
            if (validaFactura())
            {
                Factura factura;
                if (ModoFactura.Equals(Modo.nuevo))
                {
                    int id = _item.Facturas.Count() > 0 ?_item.Facturas.Max(x => x.id) + 1:1;
                    factura = new Factura() {NFactura = Convert.ToInt32(tbNumeroFactura.Text),
                        id =id,
                    Cuenta = Convert.ToDecimal(tbCuenta.Text),
                    Importe = Convert.ToDecimal(tbTotal.Text)
                    };

                    _item.Facturas.Add(factura);
                }
                else
                {
                    var row = dgvFacturas.SelectedRows;
                    if (row != null && row.Count > 0)
                    {
                        var id = row[0].Cells[0].Value;
                        if (id != null)
                        {
                            var facturaEditar = this._item.Facturas.Where(x => x.id.Equals(id)).FirstOrDefault();
                            this._item.Facturas.Remove(facturaEditar);

                            facturaEditar.NFactura = Convert.ToInt32(tbNumeroFactura.Text);
                            facturaEditar.Importe = Convert.ToDecimal(tbTotal.Text);
                            facturaEditar.Cuenta = Convert.ToDecimal(tbCuenta.Text);
                            this._item.Facturas.Add(facturaEditar);
                            if (_item.Facturas.Count > 0)
                                dgvFacturas.DataSource = _item.Facturas;
                            else
                                dgvFacturas.DataSource = null;

                           
                        }
                    }
                }
                dgvFacturas.DataSource = null;
                dgvFacturas.DataSource = _item.Facturas;
                dgvFacturas.Update();
                LimpiarSelecionGridFacturas();
                FacturasChanged();

                btEditarFac.Enabled = true;
                btEliminarFac.Enabled = true;
                btNuevaFac.Enabled = true;
                btGuardarFac.Enabled = false;

                utils.HabilitarDeshabilitarTextBox(panelFacturas.Controls, false);

            }
            this.ModoFactura = Modo.consulta;
        }

        private bool validaFactura()
        {
            bool mensaje = false;
            TextBox enfocar = new TextBox();
            if (string.IsNullOrEmpty(tbNumeroFactura.Text))
            {
                enfocar=tbNumeroFactura;
                mensaje = true;
            }
            else if (string.IsNullOrEmpty(tbTotal.Text))
            {
                enfocar = tbTotal;
                mensaje = true;
            }
            else if (string.IsNullOrEmpty(tbCuenta.Text))
            {
                enfocar = tbCuenta;
                mensaje = true;
               
            }
            if (mensaje)
            {
                MessageBox.Show("Faltan Datos");
                enfocar.Focus();
                return !mensaje;
            }
            return !mensaje;
        }
    }
}
