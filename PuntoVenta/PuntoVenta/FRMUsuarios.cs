using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;

namespace PuntoVenta
{
    public partial class FRMClientes : Form
    {
        private Clientes clientes;
        private ControladorCLI controladorcli;
        public FRMClientes()
        {
            InitializeComponent();
        }

        private void BTNAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //se instancia un producto
                this.clientes = new Clientes();

                //se asignan los valores ingresados por el usuario
                this.clientes.Cedula = this.TXTCedula.Text;
                this.clientes.Nombre = this.TXTNombre.Text;
                this.clientes.Apellidos = this.TXTApellidos.Text;
                this.clientes.Telefono = this.TXTTelefono.Text;
                this.clientes.Direccion = this.TXTDireccion.Text;
                this.controladorcli.registrar(this.clientes);
                estadoinicial();
                limpiarPantalla();

                MessageBox.Show("Cliente registro:\n" + this.clientes.Cedula + "\nNombre" + this.clientes.Nombre + "\nApellidos" + this.clientes.Apellidos);


            }
            catch (Exception ex)
            {

                MessageBox.Show("error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FRMClientes_Load(object sender, EventArgs e)
        {
            this.controladorcli = new ControladorCLI(this.obtenerStringConexion());
            this.estadoinicial();
        }

        private string obtenerStringConexion()
        {
            string cnx;
            cnx = "data source=LAPTOP-VT1BDFFU\\SQLEXPRESS;initial catalog=PuntoVenta;user id=AppPuntoVenta;password=123456";
            return cnx;
        }

        public void estadoinicial()
        {
            //botones para las acciones
            this.BTNAgregar.Enabled = false;
            this.BTNModificar.Enabled = false;
            this.BTNEliminar.Enabled = false;
            this.BTNConsultar.Enabled = true;
            this.BTNCancelar.Enabled = true;

            this.TXTCedula.Enabled = true;
            this.TXTNombre.Enabled = false;
            this.TXTApellidos.Enabled = false;
            this.TXTTelefono.Enabled = false;

            this.TXTDireccion.Enabled = false;
        }

        private void BTNConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                //se instancia del controlador
                this.controladorcli = new ControladorCLI(this.obtenerStringConexion());
                //por medio de controlador buscamos el producto
                this.clientes = this.controladorcli.consultar(this.TXTCedula.Text);
                //se valida la instancia del producto
                if (this.clientes != null)
                {
                    this.TXTCedula.Text = clientes.Cedula;
                    this.TXTNombre.Text = clientes.Nombre;
                    this.TXTApellidos.Text = clientes.Apellidos;
                    this.TXTTelefono.Text = clientes.Telefono;
                    this.TXTDireccion.Text = clientes.Direccion;

                    this.estadopantallamodificar();

                }



            }
            catch (Exception ex)
            {
                estadoagregar();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void estadopantallamodificar()
        {
            this.BTNConsultar.Enabled = false;
            this.BTNAgregar.Enabled = false;
            this.BTNModificar.Enabled = true;
            this.BTNEliminar.Enabled = true;

            this.TXTCedula.Enabled = false;
            this.TXTNombre.Enabled = true;
            this.TXTApellidos.Enabled = true;
            this.TXTTelefono.Enabled = true;
            this.TXTDireccion.Enabled = true;

        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientes = new Clientes();
                this.clientes.Cedula = this.TXTCedula.Text;
                this.clientes.Nombre = this.TXTNombre.Text;
                this.clientes.Apellidos = this.TXTApellidos.Text;
                this.clientes.Telefono = this.TXTTelefono.Text;
                this.clientes.Direccion = this.TXTDireccion.Text;
                this.controladorcli.modificar(this.clientes);

                MessageBox.Show("Cliente Modificado:\n" + this.clientes.Cedula + "\nNombre" + this.clientes.Nombre + "\nApellidos" + this.clientes.Apellidos);
                this.limpiarPantalla();
                this.estadoinicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                this.controladorcli.eliminar(this.TXTCedula.Text);
                limpiarPantalla();
                estadoinicial();
                MessageBox.Show("Cliente Eliminado:", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw ex;
            }
        }

        private void limpiarPantalla()
        {
            this.TXTCedula.Clear();
            this.TXTNombre.Clear();
            this.TXTApellidos.Clear();
            this.TXTTelefono.Clear();
            this.TXTDireccion.Clear();
        }

        public void estadoagregar()
        {
            this.BTNConsultar.Enabled = false;
            this.BTNAgregar.Enabled = true;
            this.BTNModificar.Enabled = false;
            this.BTNEliminar.Enabled = false;

            this.TXTCedula.Enabled = false;
            this.TXTNombre.Enabled = true;
            this.TXTApellidos.Enabled = true;
            this.TXTTelefono.Enabled = true;
            this.TXTDireccion.Enabled = true;

        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            estadoinicial();
            limpiarPantalla();
        }
    }
}
