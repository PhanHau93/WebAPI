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
        private Utilidades utils = new Utilidades();
        private List<ClientItem> listadoClientes;
        private IServicioCliente _servicioCliente = new AppGes.Fake.ClientFake();

        public ClientesForm()
        {
            this.modoApertura = Convert.ToInt32(Modo.consulta);

            InitializeComponent();

            CargaGrid();
        }

        public ClientesForm(int id, bool editar) //Editar
        {
            this.modoApertura = Modo.consulta;
            this.idCliente = id;
            InitializeComponent();

            CargaGrid();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            CargaFormularioClientes();

        }

        private void CargaFormularioClientes()
        {
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Width = 725;
            this.Height = 500;

            editarToolStripMenuItem.Enabled = true;
            nuevoToolStripMenuItem.Enabled = true;
            dgvClientes.Enabled = true;

            if (modoApertura.Equals(Modo.edicion))
            {
                dgvClientes.Enabled = false;
                cargarClientePorId(idCliente);
            }
            else //(modoApertura.Equals(Modo.consulta))
            {
                utils.HabilitarDeshabilitarTextBox(this.Controls, false);
                if (idCliente > 0)
                    cargarClientePorId(idCliente);

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
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
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
                        _servicioCliente.deleteClient(Convert.ToInt32(id));
                        listadoClientes.Remove(listadoClientes.Where(x => x.Id.Equals(id)).FirstOrDefault());
                        CargaGrid();
                    }
                }
            }
        }

    }
}
