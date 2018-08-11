using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importancion de modelo
using Modelo;
//importacion de controlador
using Controlador;

namespace PuntoVenta
{
    public partial class FrmProductos : Form
    {

        //variable de objeto modelo
        private Productos producto;
        //variable controlador para la interfas de usuario
        private ControladorADO controlador;

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TXTDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //se instancia un producto
                this.producto = new Productos();

                //se asignan los valores ingresados por el usuario
                this.producto.codigo = this.TXTCodigo.Text;
                this.producto.descripcion = this.TXTDescripcion.Text;
                this.producto.PrecioCompra = decimal.Parse(this.TXTPrecioCompra.Text.Trim());
                this.producto.descuento = int.Parse(this.NDUDescuento.Value.ToString());
                this.producto.impuesto = int.Parse(this.NUDImpuesto.Value.ToString());
                this.producto.fechaRegistro = this.DTPFechaRegistro.Value;
                this.producto.estado = char.Parse(this.CBXEstado.Text.Substring(0, 1));
                //se utiliza el controlador enviado por parametro
                this.controlador.registrar(this.producto);
                estadoinicial();
                limpiarPantalla();

                MessageBox.Show("Producto registro:\n" + this.producto.codigo + "\nDescripcion" + this.producto.descripcion + "\nPrecio" + this.producto.PrecioCompra);


            }
            catch (Exception ex)
            {
                
                MessageBox.Show("error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //este metodo se genera creando un evento sobre el noombre de la pestana y mostrara la informacion que quiero que muestra cuando se carga
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            //en el metodo load se debe instanciar el controlador
            this.controlador = new ControladorADO(this.obtenerStringConexion());
            this.estadoinicial();
        }
        //metodo para auteticarse a la base de datos
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

            this.TXTCodigo.Enabled = true;
            this.TXTDescripcion.Enabled = false;
            this.TXTPrecioCompra.Enabled = false;

            this.NDUDescuento.Enabled = false;
            this.NUDImpuesto.Enabled = false;

            this.DTPFechaRegistro.Enabled = false;

            this.CBXEstado.SelectedIndex = 0;
            this.CBXEstado.Enabled = false;
        }

        private void TXTCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                //se instancia del controlador
                this.controlador = new ControladorADO(this.obtenerStringConexion());
                //por medio de controlador buscamos el producto
                this.producto = this.controlador.consultar(this.TXTCodigo.Text);
                //se valida la instancia del producto
                if(this.producto != null)
                {
                    //se cargara la informacion en la interfaz
                    //se toman los atributos del producto sus valores
                    //son asignados a cada control de interfaz
                    this.TXTCodigo.Text = producto.codigo;
                    this.TXTDescripcion.Text = producto.descripcion;
                    this.TXTPrecioCompra.Text = producto.PrecioCompra.ToString();
                    this.NUDImpuesto.Value = this.producto.impuesto;
                    this.NDUDescuento.Value = this.producto.descuento;
                    this.DTPFechaRegistro.Value = this.producto.fechaRegistro;

                    //el case para el estado
                    switch(producto.estado)
                    {
                        case 'A':
                            //se realiza la seleccion de un item en el combox
                            this.CBXEstado.SelectedIndex = 0;
                            break;

                        case 'I':
                            //se marca inactivo
                            this.CBXEstado.SelectedIndex = 1;
                            break;
                    }/// cierre de case

                    //se asigna el estado de la pantalla para modififcar
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

            this.TXTCodigo.Enabled = false;
            this.TXTDescripcion.Enabled = true;
            this.TXTPrecioCompra.Enabled = true;
            this.NDUDescuento.Enabled = true;
            this.NUDImpuesto.Enabled = true;
            this.DTPFechaRegistro.Enabled = true;
            this.CBXEstado.Enabled = true;

        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //se instancia un producto
                this.producto = new Productos();

                //se asignan los valores ingresados por el usuario
                this.producto.codigo = this.TXTCodigo.Text;
                this.producto.descripcion = this.TXTDescripcion.Text;
                this.producto.PrecioCompra = decimal.Parse(this.TXTPrecioCompra.Text.Trim());
                this.producto.descuento = int.Parse(this.NDUDescuento.Value.ToString());
                this.producto.impuesto = int.Parse(this.NUDImpuesto.Value.ToString());
                this.producto.fechaRegistro = this.DTPFechaRegistro.Value;
                this.producto.estado = char.Parse(this.CBXEstado.Text.Substring(0, 1));
                //se utiliza el controlador enviado por parametro
                this.controlador.modificar(this.producto);

                MessageBox.Show("Producto Modificado:\n" + this.producto.codigo + "\nDescripcion" + this.producto.descripcion + "\nPrecio" + this.producto.PrecioCompra);
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
                this.controlador.eliminar(this.TXTCodigo.Text);
                limpiarPantalla();
                estadoinicial();
                MessageBox.Show("Producto Eliminado:","Eliminacion",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw ex;
            }
        }

        private void limpiarPantalla()
        {
            this.TXTCodigo.Clear();
            this.TXTDescripcion.Clear();
            this.TXTPrecioCompra.Text = "0";
            this.DTPFechaRegistro.Value = DateTime.Today;
            this.NDUDescuento.Value = 0;
            this.NUDImpuesto.Value = 0;
            this.CBXEstado.SelectedIndex = 0;
        }

        private void estadoagregar()
        {
            this.TXTCodigo.Enabled = false;
            this.TXTDescripcion.Enabled = true;
            this.TXTPrecioCompra.Enabled = true;
            this.DTPFechaRegistro.Enabled = true;
            this.NUDImpuesto.Enabled = true;
            this.NDUDescuento.Enabled = true;
            this.CBXEstado.Enabled = true;

            this.BTNConsultar.Enabled = false;
            this.BTNAgregar.Enabled = true;
            this.BTNModificar.Enabled = false;
            this.BTNEliminar.Enabled = false;
            this.BTNCancelar.Enabled = true;
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            estadoinicial();
            limpiarPantalla();
        }

        private void TXTCNSDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.DTGDatos.DataSource = this.controlador.busquedaProducto(this.TXTCNSDescripcion.Text.Trim()).Tables[0];
                this.DTGDatos.ReadOnly = true;
                this.DTGDatos.AutoResizeColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void DTGDatos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.TXTCodigo.Text = this.DTGDatos.SelectedRows[0].Cells[0].Value.ToString();
                //this.consultarProducto();
                //this.tabControl1

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

    }
}
