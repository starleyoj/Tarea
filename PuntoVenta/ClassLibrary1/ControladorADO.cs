using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//driver para SQL server
using System.Data.SqlClient;
//importacion de data set
using System.Data;
//Se anadio una referencia al modelo controlador en el solution explorer, importacion del modelo
using Modelo;
namespace Controlador
{
    public class ControladorADO
    {
        //Nota:Controlador debe tener referenciado modelo y punto de venta tiene que tener referenciado a controlador y modelo
        //Ado significado objetos acesso a datos
        private SqlConnection conexion;
        //Este objeto permite realizar los comandos de incercion
        private SqlCommand comando;
        //El string de conexion almacena el nombre del servidor la base de datos,servidor, user y password
        private String stringConexion;
        //Metodo encargado de registrar un producto
     public void registrar(Productos pProducto)
        { //controlar el error
            try
            {   
                //se crea una instancia de una conexion con el servidor
                this.conexion = new SqlConnection(this.stringConexion);
                //Se intenta abrir la conexion
                this.conexion.Open();
                //Se instancia el comando TRANSAC SQL
                this.comando = new SqlCommand();
                //Se debe asignarla conexion al comando
                this.comando.Connection = this.conexion;
                //se indica el tipo de comando
                this.comando.CommandType = System.Data.CommandType.Text;
                //asignar el comando transac-sql al realizar
                this.comando.CommandText = "insert into [Productos] (codigo,descripcion,precioCompra,descuento,impuesto,fechaRegistro,estado)values('"+pProducto.codigo+"','"+pProducto.descripcion+"',"+pProducto.PrecioCompra+","+pProducto.descuento+","+pProducto.impuesto+", '"+pProducto.fechaRegistro+"', '"+pProducto.estado+"')";
                //Se inserta em la base de datos
                this.comando.ExecuteNonQuery();

                //liberacion de la memoria
                this.conexion.Close();
                this.conexion.Dispose();
                this.comando.Dispose();
                

            }
            //Retorna el error
            catch (Exception ex)
            {

                throw;
            }
        }

    public ControladorADO(String pStringCnx)
        {
            this.stringConexion = pStringCnx;
        }

        public Productos consultar(string codigo)
        {
            try
            {
                
                //Pasos para consultar en la base datos
                //1) Crear la conexion
                this.conexion = new SqlConnection(this.stringConexion);

                //que funcion cumple el string de conexion
                //se encarga de indicar el nombre del servidor- la base de datos- ususario-
                //estos datos son nesesarios para conectarse al servidor SQL

                //2)Abrir conexion
                this.conexion.Open();

                //3 instanciar un comando para ejecutar  transac SQL
                this.comando = new SqlCommand();
                //4) asignar al comando la conexion sql
                this.comando.Connection = this.conexion;
                //5)indicar que tipo de comando va a ejecutar
                this.comando.CommandType = System.Data.CommandType.Text;
                //6) Escribir el transac sql para consultar
                this.comando.CommandText = "select c.codigo,c.descripcion,c.precioCompra,c.descuento,c.impuesto,c.fechaRegistro,c.estado from Productos c where codigo = '"+codigo+"' ";

                //7 instanciar un objeto de lectura
                SqlDataReader lectorDatos;

                //8 Asignar el resultado del comando al lector
                lectorDatos = this.comando.ExecuteReader();
                //declaracion de la variable producto
                Productos varTemporal = null;
                //9 Leer los datos obtenidos del servidor
                if (lectorDatos.Read())
                {

                    
                    varTemporal = new Productos();
                    //0 es la posicion donde se ubica el valor en la consulta
                    varTemporal.codigo = lectorDatos.GetValue(0).ToString();
                    varTemporal.descripcion = lectorDatos.GetValue(1).ToString();
                    varTemporal.PrecioCompra = decimal.Parse(lectorDatos.GetValue(2).ToString());
                    varTemporal.descuento = int.Parse(lectorDatos.GetValue(3).ToString());
                    varTemporal.impuesto = int.Parse(lectorDatos.GetValue(4).ToString());
                    varTemporal.fechaRegistro = DateTime.Parse(lectorDatos.GetValue(5).ToString());
                    varTemporal.estado = char.Parse(lectorDatos.GetValue(6).ToString());

                }
                else
                {
                    throw new Exception("No existe ningun producto con dicho codigo");

                }
                //se retorna el objeto en la interfaz grafica
                return varTemporal;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void modificar(Productos varProducto)
        {
            try
            {
                //se crea una instancia de una conexion con el servidor
                this.conexion = new SqlConnection(this.stringConexion);
                //Se intenta abrir la conexion
                this.conexion.Open();
                //Se instancia el comando TRANSAC SQL
                this.comando = new SqlCommand();
                //Se debe asignarla conexion al comando
                this.comando.Connection = this.conexion;
                //se indica el tipo de comando
                this.comando.CommandType = System.Data.CommandType.Text;
                //se asigna el trasac sql para modifica
                this.comando.CommandText = "update Productos set descripcion = '"+varProducto.descripcion+"',precioCompra ="+varProducto.PrecioCompra+",descuento = "+varProducto.descuento+",impuesto = "+varProducto.impuesto+",fechaRegistro = '"+varProducto.fechaRegistro+"',estado = '"+varProducto.estado+"' where codigo = '"+varProducto.codigo+"'";
                //se ejecuta el comando
                this.comando.ExecuteNonQuery();
                //liberacion de memoria
                this.conexion.Close();
                this.conexion.Dispose();
                this.comando.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void eliminar(string codigo)
        {
            //se crea una instancia de una conexion con el servidor
            this.conexion = new SqlConnection(this.stringConexion);
            //Se intenta abrir la conexion
            this.conexion.Open();
            //Se instancia el comando TRANSAC SQL
            this.comando = new SqlCommand();
            //Se debe asignarla conexion al comando
            this.comando.Connection = this.conexion;
            //se indica el tipo de comando
            this.comando.CommandType = System.Data.CommandType.Text;

            this.comando.CommandText = "update Productos set estado = 'E' where codigo = '" + codigo + "'";

            this.comando.ExecuteNonQuery();

            this.conexion.Close();
            this.conexion.Dispose();
            this.comando.Dispose();

        }

        public DataSet busquedaProducto(string descrip)
        {
            try
            {
                //cada ves que se necesita ir a realizar alguna funcion con la base de datos se debe instanciar una conexion
                this.conexion = new SqlConnection(this.stringConexion);
                //Cuendo tengo una instancia de conexion se debe intentar abrir la conexion
                this.conexion.Open();
                //se intancia un comando
                this.comando = new SqlCommand();
                //se asigna la conexion
                this.comando.Connection = this.conexion;
                //se indica el tipo de comando
                this.comando.CommandType = CommandType.StoredProcedure;
                //se indica el rpocedimiento almacenado que ejecutara el comando
                this.comando.CommandText = "[Sp_Cns_Productos]";
                //se debe asignar los parametros del comando
                this.comando.Parameters.AddWithValue("@pDescrip", descrip);
                //dataset es el contenedor de los datos que provienen de la base de datos
                DataSet datos = new DataSet();
                //Se intancia un adapatador este se encarga de llenar  el data set con los datos obtenidos por medio del comando
                //provenientes de la base de datos
                SqlDataAdapter adapter = new SqlDataAdapter();
                //se asigna el comando de seleccion
                adapter.SelectCommand = this.comando;
                //se llena el dataset con los datos seleccioneados por el comando
                //metodo fill (DataSet) recibe un dataset y lo llena de datos
                adapter.Fill(datos);
                //cierre de conexion

                this.conexion.Close();
                this.conexion.Dispose();
                this.comando.Dispose();
                adapter.Dispose();

                return datos;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool autenticado(User pUser)
        {
            try
            {
                bool autorizado = false;
                //se instancia la conexion
                this.conexion = new SqlConnection(this.stringConexion);
                //se abre la conexion
                this.conexion.Open();
                //se instancia le comando
                this.comando = new SqlCommand();
                //se asigna la conexion
                this.comando.Connection = this.conexion;
                //se asigna el comando TRANSAC-SQL
                this.comando.CommandText = "select login from Usuarios where login='"+pUser.login+"' and dbo.fn_desencriptarpassword(password) = '"+pUser.password+"'";
                //indicar el tipo de comando
                this.comando.CommandType = CommandType.Text;

                SqlDataReader lectorDatos = this.comando.ExecuteReader();

                if (lectorDatos.Read())
                {
                    autorizado = true;

                }
                else
                {
                    autorizado = false;
                }

                //liberacion
                this.conexion.Close();
                this.conexion.Dispose();
                this.comando.Dispose();
                lectorDatos = null;
                return autorizado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }//C
}//NP
