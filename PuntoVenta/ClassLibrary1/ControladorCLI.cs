using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Modelo;

namespace Controlador
{
    public class ControladorCLI
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private String stringConexion;

        public void registrar(Clientes pClientes)
        { 
            try
            {
                this.conexion = new SqlConnection(this.stringConexion);
                this.conexion.Open();
                this.comando = new SqlCommand();
                this.comando.Connection = this.conexion;
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "insert into [Clientes] (codigo,descripcion,precioCompra,descuento,impuesto,fechaRegistro,estado)values('" + pClientes.Cedula + "','" + pClientes.Nombre + "','" + pClientes.Apellidos + "','" + pClientes.Telefono + "','" + pClientes.Direccion + "')";
                this.comando.ExecuteNonQuery();
                this.conexion.Close();
                this.conexion.Dispose();
                this.comando.Dispose();


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public ControladorCLI(String pStringCnx)
        {
            this.stringConexion = pStringCnx;
        }

        public Clientes consultar(string cedula)
        {
            try
            {             
                this.conexion = new SqlConnection(this.stringConexion);
                this.conexion.Open();
                this.comando = new SqlCommand();
                this.comando.Connection = this.conexion;
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "select c.cedula,c.nombre,c.apellidos,c.telefono,c.direccion from Clientes c where cedula = '" + cedula + "' ";
                SqlDataReader lectorDatos;
                lectorDatos = this.comando.ExecuteReader();
                Clientes varTemporal = null;
                if (lectorDatos.Read())
                {


                    varTemporal = new Clientes();
                    varTemporal.Cedula = lectorDatos.GetValue(0).ToString();
                    varTemporal.Nombre = lectorDatos.GetValue(1).ToString();
                    varTemporal.Apellidos = lectorDatos.GetValue(2).ToString();
                    varTemporal.Telefono = lectorDatos.GetValue(3).ToString();
                    varTemporal.Direccion = lectorDatos.GetValue(4).ToString();

                }
                else
                {
                    throw new Exception("No existe ningun cliente con dicha cedula");

                }
                return varTemporal;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void modificar(Clientes varClientes)
        {
            try
            {
                this.conexion = new SqlConnection(this.stringConexion);
                this.conexion.Open();
                this.comando = new SqlCommand();
                this.comando.Connection = this.conexion;
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "update Clientes set cedula = '" + varClientes.Cedula + "', nombre =" + varClientes.Nombre + ",apellidos = " + varClientes.Apellidos + ",telefono = " + varClientes.Telefono + ",direccion = '" + varClientes.Direccion + "'";
                this.comando.ExecuteNonQuery();
                this.conexion.Close();
                this.conexion.Dispose();
                this.comando.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void eliminar(string cedula)
        {
            this.conexion = new SqlConnection(this.stringConexion);
            this.conexion.Open();
            this.comando = new SqlCommand();
            this.comando.Connection = this.conexion;
            this.comando.CommandType = System.Data.CommandType.Text;
            this.comando.CommandText = "delete from Clientes where cedula = '" + cedula + "'";
            this.comando.ExecuteNonQuery();
            this.conexion.Close();
            this.conexion.Dispose();
            this.comando.Dispose();

        }
    }
}
