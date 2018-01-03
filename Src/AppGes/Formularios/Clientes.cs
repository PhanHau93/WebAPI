using AppGes.Enumerados;
using AppGes.Interfaces;
using AppGes.Models;
using AppGes.Services;
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
    public partial class ClientesForm : Form
    {
        private int modoApertura { get; set; }
        private int idCliente { get; set; }

        public ClientItem clienteBusqueda { get; set; }

        private Utilidades utils = new Utilidades();
        private List<ClientItem> listadoClientes;
        private IServicioCliente _servicioCliente = new AppGes.Services.ServicioCliente();
        private ITrabajos _servicioTrabajo = new AppGes.Services.TrabajosService();

        public ClientesForm()
        {
            this.modoApertura = Convert.ToInt32(Modo.consulta);

            InitializeComponent();

            CargaGrid();

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        public ClientesForm(int id, bool busqueda) //Editar
        {
            if (busqueda)
                this.modoApertura = Modo.busqueda;
            else
                this.modoApertura = Modo.consulta;

            this.idCliente = id;
            InitializeComponent();

            CargaGrid();
            CargaFormularioClientes();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
           
            CargaFormularioClientes();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            

        }

        private void CargaFormularioClientes()
        {
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Width = 725;
            this.Height = 500;

            editarToolStripMenuItem.Enabled = true;
            nuevoToolStripMenuItem.Enabled = true;
            eliminarToolStripMenuItem.Enabled = true;
            cancelarToolStripMenuItem.Enabled = false;
            dgvClientes.Enabled = true;

            if (modoApertura.Equals(Modo.edicion))
            {
                dgvClientes.Enabled = false;
                cargarClientePorId(idCliente);
                panelBusqueda.Visible = false;
            }
            else //(modoApertura.Equals(Modo.consulta))
            {
                
                utils.HabilitarDeshabilitarTextBox(this.Controls, false);
                panelBusqueda.Visible = true;
                tx_Apellidos.Enabled = true;
                tx_Nombre.Enabled = true;
                if (idCliente > 0)
                    cargarClientePorId(idCliente);

                if (modoApertura.Equals(Modo.busqueda))
                {
                    editarToolStripMenuItem.Enabled = false;
                    nuevoToolStripMenuItem.Enabled = false;
                    eliminarToolStripMenuItem.Enabled = false;
                    cancelarToolStripMenuItem.Enabled = false;
                    guardarToolStripMenuItem.Enabled = true;
                    salirToolStripMenuItem.Enabled = false;
                }

            }

        }

        private void cargarClientePorId(int id)
        {
            var item = _servicioCliente.getClientById(id);
            if (item != null)
            {
                tbClienteId.Text = item.Id.ToString();
                tbApellidos.Text = item.Apellidos;
                tbNombre.Text = item.Nombre;
                tbNif.Text = item.NIF;
                tbTelefono.Text = item.Telefono.ToString();
                tbLocalidad.Text = item.Localidad;
                tbCP.Text = item.CP.ToString();
                tbObservaciones.Text = item.Observaciones;
                tbEmail.Text = item.Email;
            }
            else
            {
                MessageBox.Show("No se han encontrado datos");
            }


        }

        private void CargaGrid()
        {
            if (listadoClientes == null)
            {
                var list = _servicioCliente.getClient();
                if (list != null)
                    listadoClientes = list.ToList<ClientItem>();
                else
                    listadoClientes = new List<ClientItem>();
            }
            dgvClientes.DataSource = null;

            dgvClientes.DataSource = listadoClientes.OrderBy(x => x.Id).ToList<ClientItem>();

            //dgvClientes.Sort(dgvClientes.Columns["Id"], ListSortDirection.Ascending);
            dgvClientes.Update();


        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modoApertura != Modo.consulta)
                if (ValidarGuardarCliente())
                {
                    modoApertura = Modo.consulta;
                    CargaFormularioClientes();
                }
        }

        private bool ValidarGuardarCliente()
        {
            bool validaNombre = true;
            bool validaApellido = true;
            bool validaNif = true;

            validaNombre = utils.ValidaTexto(tbNombre);
            validaApellido = utils.ValidaTexto(tbApellidos);

            if (!string.IsNullOrEmpty(tbNif.Text))
                if (!utils.Valida_CIF(tbNif.Text) || !utils.VerificarNIF(tbNif.Text))
                {
                    MessageBox.Show("El formato del NIF no es correcto");
                    tbNif.Focus();
                    validaNif = false;
                }

            if (validaNombre && validaApellido && validaNif)
            {
                //Guardarmos
                GuardarCliente();
                //Actualizamos el Grid
                this.listadoClientes = null;
                CargaGrid();
                return true;
            }
            return false;
        }

        private void GuardarCliente()
        {
            ClientItem item;
            item = new ClientItem();

            if (!string.IsNullOrEmpty(tbClienteId.Text))
                item.Id = Convert.ToInt16(tbClienteId.Text);

            item.Apellidos = tbApellidos.Text;
            item.Nombre = tbNombre.Text;
            item.NIF = tbNif.Text;

            if (!string.IsNullOrEmpty(tbTelefono.Text))
                item.Telefono = Convert.ToInt32(tbTelefono.Text);

            item.Localidad = tbLocalidad.Text;

            if (!string.IsNullOrEmpty(tbCP.Text))
                item.CP = Convert.ToInt32(tbCP.Text);

            item.Observaciones = tbObservaciones.Text;

            item.Email = tbEmail.Text;

            if (modoApertura.Equals(Modo.nuevo))
                _servicioCliente.addClient(item);
            else
                _servicioCliente.updateClient(item);


        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            CargarClienteGrid();
        }

        private void CargarClienteGrid()
        {
            if (modoApertura != Modo.nuevo)
            {
                var row = dgvClientes.SelectedRows;
                if (row != null && row.Count > 0)
                {
                    var id = row[0].Cells[0].Value;
                    if (id != null)
                    {
                        cargarClientePorId(Convert.ToInt32(id));
                    }
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utils.HabilitarDeshabilitarTextBox(this.Controls, true);
            tbClienteId.Enabled = false;

            utils.LimpiarTextBox(this.Controls);

            modoApertura = Modo.nuevo;

            editarToolStripMenuItem.Enabled = false;
            nuevoToolStripMenuItem.Enabled = false;
            eliminarToolStripMenuItem.Enabled = false;
            cancelarToolStripMenuItem.Enabled = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (modoApertura.Equals(Modo.nuevo) || modoApertura.Equals(Modo.edicion))
            {
                DialogResult dr = MessageBox.Show("Existen Cambios Sin Guardar. ¿Desea Salir?", "", MessageBoxButtons.OKCancel);
                if (dr.Equals(DialogResult.OK))
                    this.Close();
                return;
            }

            this.Close();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utils.HabilitarDeshabilitarTextBox(this.Controls, true);
            modoApertura = Modo.edicion;
            dgvClientes.Enabled = false;

            editarToolStripMenuItem.Enabled = false;
            nuevoToolStripMenuItem.Enabled = false;
            eliminarToolStripMenuItem.Enabled = false;
            cancelarToolStripMenuItem.Enabled = true;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarCliente();
        }

        private void EliminarCliente()
        {
           
            DialogResult dr = MessageBox.Show("Va a eliminar un Cliente. ¿Desea Continuar?", "", MessageBoxButtons.OKCancel);

            if (dr.Equals(DialogResult.OK))
            {
                var row = dgvClientes.SelectedRows;
                if (row != null && row.Count.Equals(1))
                {
                    var id = row[0].Cells[0].Value;
                    if (id != null)
                    {
                        var item = _servicioTrabajo.GetByClientId(Convert.ToInt32(id));
                        if (item.Count() > 0)
                        {
                            MessageBox.Show("El cliente tiene trabajos asociados, no se permite eliminarlo.");
                            return;
                        }
                        _servicioCliente.deleteClient(Convert.ToInt32(id));
                        listadoClientes.Remove(listadoClientes.Where(x => x.Id.Equals(id)).FirstOrDefault());
                        CargaGrid();
                    }
                }
            }
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            this.modoApertura = Modo.consulta;
            CargaFormularioClientes();
            CargarClienteGrid();
        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clienteBusqueda = new ClientItem();

            var row = dgvClientes.SelectedRows;
            if (row != null && row.Count > 0)
            {
                var id = row[0].Cells[0].Value;
                if (id != null)
                {
                    var item = _servicioCliente.getClientById(Convert.ToInt32(id));

                    clienteBusqueda = item;

                    this.Close();
                }
            }
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

            for (int u = 0; u < dgvClientes.RowCount; u++)
            {
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvClientes.DataSource];
                currencyManager1.SuspendBinding();
                if (header > 0)
                {
                    if (dgvClientes.Rows[u].Cells[header].Value.ToString().Contains(filtro))
                    {
                        dgvClientes.Rows[u].Visible = true;
                    }
                    else
                    {
                        dgvClientes.Rows[u].Visible = false;
                    }
                }
                else
                {
                    if (dgvClientes.Rows[u].Cells[2].Value.ToString().Contains(tx_Apellidos.Text) &&
                        dgvClientes.Rows[u].Cells[1].Value.ToString().Contains(tx_Nombre.Text))
                    {
                        dgvClientes.Rows[u].Visible = true;
                    }
                    else
                    {
                        dgvClientes.Rows[u].Visible = false;
                    }
                }
                currencyManager1.ResumeBinding();
            }

            bt_Limpiar.Enabled = true;





        }

        private void bt_Limpiar_Click(object sender, EventArgs e)
        {

            for (int u = 0; u < dgvClientes.RowCount; u++)
            {
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvClientes.DataSource];
                currencyManager1.SuspendBinding();

                dgvClientes.Rows[u].Visible = true;

                currencyManager1.ResumeBinding();
            }
            tx_Apellidos.Text = "";
            tx_Nombre.Text = "";
            bt_Limpiar.Enabled = false;
        }

        
    }
}
