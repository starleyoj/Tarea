using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{

    public class Clientes
    {
        private string strCedula, strNombre, strApellidos, strTelefono, strDireccion;

        public string Cedula
        {
            set
            {
                //trown se utiliza para tirar la excepcion nivel UI
                if (value.Trim().Equals(""))
                    throw new Exception("Nose permite la cedula en blanco");

                else
                {
                    this.strCedula = value.Trim();
                }

            }
            get
            {
                return this.strCedula;


            }
        }

        public string Nombre
        {
            set
            {
                //trown se utiliza para tirar la excepcion nivel UI
                if (value.Trim().Equals(""))
                    throw new Exception("Nose permite el nombre en blanco");

                else
                {
                    this.strNombre = value.Trim();
                }

            }
            get
            {
                return this.strNombre;


            }
        }

        public string Apellidos
        {
            set
            {
                //trown se utiliza para tirar la excepcion nivel UI
                if (value.Trim().Equals(""))
                    throw new Exception("Nose permite el espacio apellidos en blanco");

                else
                {
                    this.strApellidos = value.Trim();
                }

            }
            get
            {
                return this.strApellidos;


            }
        }

        public string Telefono
        {
            set
            {
                //trown se utiliza para tirar la excepcion nivel UI
                if (value.Trim().Equals(""))
                    throw new Exception("Inserte un telefono");

                else
                {
                    this.strTelefono = value.Trim();
                }

            }
            get
            {
                return this.strTelefono;


            }
        }

        public string Direccion
        {
            set
            {
                //trown se utiliza para tirar la excepcion nivel UI
                if (value.Trim().Equals(""))
                    throw new Exception("Nose permite la direccion en blanco");

                else
                {
                    this.strDireccion = value.Trim();
                }

            }
            get
            {
                return this.strDireccion;


            }
        }
    }
}
