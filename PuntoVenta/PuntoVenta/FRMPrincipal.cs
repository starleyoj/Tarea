using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVenta
{
    public partial class FRMPrincipal : Form
    {
        //Declaracion de variables dentro del formulario, variable de formulario login
        private FRMLogin ventanaLogin;
        //Variable para formulario producto
        private FrmProductos ventanaProductos;

        private FRMClientes ventanaClientes;

        
       
        public FRMPrincipal()
        {
            InitializeComponent();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sintaxis para llamar una herramientas
            System.Diagnostics.Process.Start("Excel.exe");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword.exe");
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void powerPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("powerpnt.exe");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {



        }

        private void FRMPrincipal_Load(object sender, EventArgs e)
        {
            //Vamos a mostrar la notificacion de inicio
            this.notifyIcon1.ShowBalloonTip(25);
            //Variable formulario
            //Se instancia una ventana de login
            this.ventanaLogin = new FRMLogin();
            this.ventanaLogin.setPrincipal(this);
            //mostrar la ventana de login
            this.ventanaLogin.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CerrarPrincipal()
        {
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se muestra la ventana de login para autenticarse
            this.ventanaLogin.Visible = true;
            this.ventanaLogin.EstadoInicial();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se instancia la ventana para los prodctos
            this.ventanaProductos = new FrmProductos();
            //Se muestra la interfaz para productos
            this.ventanaProductos.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ventanaClientes = new FRMClientes();
            this.ventanaClientes.ShowDialog();
        }
    }
}
