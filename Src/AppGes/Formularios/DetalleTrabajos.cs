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
        public bool facturaModificada = false;
        private Utilidades utils = new Utilidades();
        private ITrabajos _servicioTrabajo = new AppGes.Services.TrabajosService();
        private IServicioCliente _servicioCliente = new AppGes.Services.ServicioCliente();
        private TrabajoItem _item = new TrabajoItem();
        private ClientItem _client;


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
            else
            {
                CargaModoConsulta(id);
                EditarTrabajo();
            }


        }

        private void CargaModoConsulta(int id)
        {
            utils.HabilitarDeshabilitarTextBox(this.Controls, false);
            CargarDatosPorId(id);
            panelFacturas.Enabled = false;
            panelCliente.Enabled = false;
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
                {
                    dtpFechaEntrada.Value = trabajo.FechaEntrada.Value;
                    dtpFechaEntrada.Checked = true;
                }
                else
                    dtpFechaEntrada.Visible = false;

                if (trabajo.FechaEntrega.HasValue)
                {
                    dtpFechaEntrega.Value = trabajo.FechaEntrega.Value;
                    dtpFechaEntrada.Checked = true;
                }
                else
                    dtpFechaEntrega.Visible = false;

                if (trabajo.FechaReal.HasValue)
                {
                    dtpFechaReal.Value = trabajo.FechaReal.Value;
                    dtpFechaReal.Checked = true;
                }
                else
                    dtpFechaReal.Visible = false;

                tbObservaciones.Text = trabajo.Observaciones;

                this._item = trabajo;
                this._client = trabajo.Cliente;

                if (trabajo.Facturas != null && trabajo.Facturas.Count > 0)
                {
                    dgvFacturas.DataSource = null;
                    BindingList<Factura> bl = new BindingList<Factura>(_item.Facturas.ToList());

                    dgvFacturas.DataSource = bl;
                    //dgvFacturas.Update();
                    //FacturasChanged();
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
            ClientesForm clientesForm = new ClientesForm(-1, true);
            clientesForm.ShowDialog();

            if (clientesForm.clienteBusqueda != null)
            {
                var client = clientesForm.clienteBusqueda;
                CargaCliente(client);
                _client = client;
            }
        }

        private void CargaCliente(ClientItem client)
        {
            tbClientId.Text = client.Id.ToString();
            tbNombre.Text = client.Nombre;
            tbApellidos.Text = client.Apellidos;
            tbNif.Text = client.NIF;
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
                editarToolStripMenuItem.Enabled = false;
            }

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ModoApertura.Equals(Modo.nuevo) || ModoApertura.Equals(Modo.edicion))
            {
                DialogResult dr = MessageBox.Show("Existen Cambios Sin Guardar. ¿Desea Salir?", "", MessageBoxButtons.OKCancel);
                if (dr.Equals(DialogResult.OK))
                    this.Close();
                return;
            }

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
            HabilitarNuevaFactura();

        }

        private void HabilitarNuevaFactura()
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

            tbNumeroFactura.Focus();
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
                    var facturaEliminar = this._item.Facturas.Where(x => x.Id.Equals(id)).FirstOrDefault();
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
            if (dgvFacturas.Rows.Count > 0)
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
                    if (_item.Facturas == null)
                        _item.Facturas = new List<Factura>();

                    int id = _item.Facturas.Count() > 0 ? _item.Facturas.Max(x => x.Id) + 1 : 1;
                    factura = new Factura()
                    {
                        NFactura = Convert.ToInt32(tbNumeroFactura.Text),
                        Id = id,
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
                            var facturaEditar = this._item.Facturas.Where(x => x.Id.Equals(id)).FirstOrDefault();
                            this._item.Facturas.Remove(facturaEditar);

                            facturaEditar.NFactura = Convert.ToInt32(tbNumeroFactura.Text);
                            facturaEditar.Importe = Convert.ToDecimal(tbTotal.Text);
                            facturaEditar.Cuenta = Convert.ToDecimal(tbCuenta.Text);
                            this._item.Facturas.Add(facturaEditar);
                            if (_item.Facturas.Count > 0)
                            {
                                BindingList<Factura> bl2 = new BindingList<Factura>(_item.Facturas.ToList());
                                dgvFacturas.DataSource = bl2;
                            }
                            else
                                dgvFacturas.DataSource = null;


                        }
                    }
                }
                dgvFacturas.DataSource = null;
                BindingList<Factura> bl = new BindingList<Factura>(_item.Facturas.ToList());
                dgvFacturas.DataSource = bl;
                LimpiarSelecionGridFacturas();
                FacturasChanged();

                btEditarFac.Enabled = true;
                btEliminarFac.Enabled = true;
                btNuevaFac.Enabled = true;
                btGuardarFac.Enabled = false;

                utils.HabilitarDeshabilitarTextBox(panelFacturas.Controls, false);
                this.ModoFactura = Modo.consulta;

            }
           
        }

        private bool validaFactura()
        {
            bool mensaje = false;
            TextBox enfocar = new TextBox();
            if (string.IsNullOrEmpty(tbNumeroFactura.Text))
            {
                enfocar = tbNumeroFactura;
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

        private void tbClientId_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbClientId.Text))
            {
                int id;
                Int32.TryParse(tbClientId.Text, out id);

                if (id > 0)
                {
                    var item = _servicioCliente.getClientById(id);
                    if (item != null)
                    {
                        CargaCliente(item);
                        _client = item;
                    }
                    else
                    {
                        MessageBox.Show("Cliente No Encontrado");
                        utils.LimpiarTextBox(panelCliente.Controls);
                        _client = null;
                        tbClientId.Focus();
                    }

                }
            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ModoApertura.Equals(Modo.consulta))
            {
                if (ValidarGuardarFactura())
                {
                    if (ModoApertura.Equals(Modo.nuevo))
                    {
                        _servicioTrabajo.Add(_item);
                    }
                    else
                    {
                        _servicioTrabajo.Update(_item);
                    }
                    MessageBox.Show("Factura Guardada");
                    facturaModificada = true;
                    this.Close();
                    return;
                }
            }
            facturaModificada = false;

        }

        private bool ValidarGuardarFactura()
        {
            if (_client == null)
            {
                MessageBox.Show("Datos de Cliente Obligatorio");
                if (tbClientId.CanFocus)
                    tbClientId.Focus();
                return false;
            }
            else
            {
                //_item.Cliente = _client;
                _item.clienteID = _client.Id;

            }


            if (string.IsNullOrEmpty(tbPresupuesto.Text))
            {
                MessageBox.Show("Número de presupuesto Obligatoio");
                if (tbPresupuesto.CanFocus)
                    tbPresupuesto.Focus();
                return false;
            }
            else
            {
                int id;
                int.TryParse(tbPresupuesto.Text, out id);
                if (id > 0)
                    _item.NPresupuesto = Convert.ToInt32(tbPresupuesto.Text);
                else
                {
                        MessageBox.Show("Formatio incorrecto");
                    tbPresupuesto.Text = string.Empty;
                    if (tbPresupuesto.CanFocus)
                        tbPresupuesto.Focus();
                }


            }

            _item.Observaciones = tbObservaciones.Text;
            if (!dtpFechaEntrega.Checked)
            {
                MessageBox.Show("Fecha de entrega Obligatoria");
                if (dtpFechaEntrega.CanFocus)
                    dtpFechaEntrega.Focus();
                return false;
            }
            else
            {
                _item.FechaEntrada = dtpFechaEntrega.Value;
            }
            if (!dtpFechaEntrada.Checked)
            {
                MessageBox.Show("Fecha de entrada Obligatoria");
                if (dtpFechaEntrada.CanFocus)
                    dtpFechaEntrada.Focus();
                return false;
            }
            else
            {
                _item.FechaEntrada = dtpFechaEntrada.Value;
            }

           

            if (dtpFechaReal.Checked)
            {
                _item.FechaReal = dtpFechaReal.Value;
            }

            _item.Finalizado = chkFinalizado.Checked;

            if (_item.Facturas == null || _item.Facturas.Equals(0))
            {
                MessageBox.Show("Obligatorio Introducir Facturas asociadas");
                HabilitarNuevaFactura();
                return false;
            }

            return true;
        }
    }
}
