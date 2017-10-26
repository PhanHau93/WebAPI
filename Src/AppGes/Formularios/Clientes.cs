using AppGes.Enumerados;
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
    public partial class ClientesForm : Form
    {
        private int modoApertura { get; set; }
        private int idCliente { get; set; }
        private Utilidades utils = new Utilidades();
        private List<ClientItem> listadoClientes;
        public ClientesForm()
        {
            this.modoApertura = Convert.ToInt32(Modo.nuevo);

            InitializeComponent();

            CargaGrid();
        }

        public ClientesForm(int id, bool editar) //Editar
        {
            this.modoApertura = editar ? Modo.edicion : Modo.consulta;
            this.idCliente = id;
            InitializeComponent();

            CargaGrid();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Width = 725;
            this.Height = 500;

            if (modoApertura.Equals(Modo.consulta))
            {
                utils.HabilitarDeshabilitarTextBox(this.Controls, false);
                if (idCliente > 0)
                    cargarClientePorId(idCliente);

            }
            else if (modoApertura.Equals(Modo.edicion))
            {
                cargarClientePorId(idCliente);
            }
        }

        private void cargarClientePorId(int id)
        {
            tbClienteId.Text = idCliente.ToString();
        }

        private void CargaGrid()
        {
            if (listadoClientes != null)
                this.listadoClientes = new List<ClientItem>();



        }
    }
}
