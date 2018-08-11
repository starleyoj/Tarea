using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importar la libreria del controlador
using Controlador;
using Modelo;

namespace PuntoVenta
{
    public partial class FRMLogin : Form
    {
        //variable para el usuario
        private User user;
        //variable para formulario principal
        private FRMPrincipal FRMPrincipal;
        //Variable para utilizar el controlador
        private ControladorADO controlador;
        //Metodo encargado de asignar la instancia del formulario principal
        public void setPrincipal(FRMPrincipal frmPrinc)
        {
            this.FRMPrincipal = frmPrinc;
        }
        //Constructor del formulario login
        public FRMLogin()
        {
            InitializeComponent();
            //Se instancia el controlador
            this.controlador = new ControladorADO(this.obtenerStringConexion());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            //Se utiliza el metodo cerrar principal
            this.FRMPrincipal.CerrarPrincipal();
        }

        private void BTNAceptar_Click(object sender, EventArgs e)
        {
                intentoAutentificacion();
        }

        private void TXTContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Logica de control de teclas
            if(e.KeyChar == (char) (Keys.Enter))
            {
                intentoAutentificacion();

            }
        }

        public void intentoAutentificacion()

        { 
            //se instancia un usuario con los valores de la interfaz grafica
            this.user = new User() { login = this.TXTUsuario.Text.Trim(),password = this.TXTContrasenia.Text.Trim() };
            //el controlador recibe el usuario utilizando el metodo autenticado para revisar en la bsae de datos
            if (this.controlador.autenticado(this.user))
            {
                MessageBox.Show("Bienvenido", "Sesion iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Se oculat el fomulario de autentificacion
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario o Contrasena incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.TXTUsuario.Clear();
                this.TXTContrasenia.Clear();
            }
        }
        public void EstadoInicial()
        {
            this.TXTContrasenia.Clear();
            this.TXTUsuario.Clear();
        }

        private string obtenerStringConexion()
        {
            string cnx;
            cnx = "data source=LAPTOP-VT1BDFFU\\SQLEXPRESS;initial catalog=PuntoVenta;user id=AppPuntoVenta;password=123456";
            return cnx;
        }
    }//Cierre de formulario
}//Cierre de namespace
