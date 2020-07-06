using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        public delegate void DelegadoEstado(object sender, EventArgs e);

        public event DelegadoEstado InformarEstado;

        #region Constructor

        /// <summary>
        /// Crea un nueo paquete
        /// </summary>
        /// <param name="direccionEntrega">Direccion donde va a ser entregado</param>
        /// <param name="trackingID">Numero de id</param>
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingID;
        }

        #endregion

        #region Propiedades

        public string DireccionEntraega 
        { 
            get
            {
                return this.direccionEntrega;
            }    
            set
            {
                this.direccionEntrega = value;
            }
        }

        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Convierte a string el elemento
        /// </summary>
        /// <param name="elemento">PAquete a mostrar</param>
        /// <returns></returns>
        public string MostarDatos(IMostrar<Paquete> elemento)
        {
            Paquete paquete = (Paquete) elemento;
            return string.Format("{0} para {1}", paquete.trackingID, paquete.direccionEntrega);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("ID: {0}\n",this.trackingID);
            sb.AppendFormat(" Direccion de entrega: {0}\n", this.direccionEntrega);
            sb.AppendFormat(" Estado de entrega: {0}\n", this.estado);

            return sb.ToString();
        }
        
        public void MockCicloDeVida()
        {
            do
            {
                System.Threading.Thread.Sleep(4000);
                this.estado++;
                if(this.InformarEstado != null)
                {
                    this.InformarEstado.Invoke(null,null);
                }

            } while (this.estado != EEstado.Entregado);
            PaqueteDAO.Insertar(this);
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Dos paquetes son iguales si tiene el mismo trckingID
        /// </summary>
        /// <param name="p1">Paquete a evaluar</param>
        /// <param name="p2">Paquete a evaluar</param>
        /// <returns>True si son iguales</returns>
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            if(p1.trackingID == p2.trackingID)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Dos paquetes son diferentes si tiene el diferente trckingID
        /// </summary>
        /// <param name="p1">Paquete a evaluar</param>
        /// <param name="p2">Paquete a evaluar</param>
        /// <returns>True si son diferentes</returns>
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        #endregion

        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
    }
}
