using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Productos
    {
        //propiedades
        #region
        //private
        private string strCodigo, strDescripcion;
        private decimal dclPrecioCompra;
        private int intDescuento, intImpuesto;
        private DateTime dtpFechaRegistro;
        private char chrEstado;
        #endregion
        public string codigo
        {
            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nose permite el codigo en blanco");
                else

                    this.strCodigo = value;
            }
            get
            {
                return this.strCodigo;
            }

        }

        public string descripcion
        {
            set
            {
                //trown se utiliza para tirar la excepcion nivel UI
                if (value.Trim().Equals(""))
                    throw new Exception("Nose permiten la descripcion en blanco");

                else
                {
                    this.strDescripcion = value.Trim();
                }

            }
            get
            {
                return this.strDescripcion;


            }
        }

        public decimal PrecioCompra
        {
            set
            {
                if (value <= 0)
                    throw new Exception("Precio compra incorrecto");
                else
                {
                    this.dclPrecioCompra = value;
                }
            }

            get
            {
                return this.dclPrecioCompra;

            }
        }

        public int descuento
        {
            set
            {
                if (value <= 0)
                    throw new Exception("Valor incorrecto para el descuento");
                else
                    this.intDescuento = value;

            }
            get
            {
                return this.intDescuento;

            }
        }

        public int impuesto
        {
            set
            {
                if (value < 0)
                    throw new Exception("Valor de impuesto incorrecto");
                else
                    this.intImpuesto = value;

            }

            get
            {
                return this.intImpuesto;

            }
        }

        public DateTime fechaRegistro
        {
            set
            {
                this.dtpFechaRegistro = value;

            }

            get
            {
                return this.dtpFechaRegistro;

            }
        }

        public char estado
        {
            set
            {
                this.chrEstado = value;
            }

            get
            {
                return this.chrEstado;

            }
        }




    }//Cierre de clase
}//Cierre NameSpace
