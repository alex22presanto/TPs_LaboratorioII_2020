using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Interfaz;
using Excepciones;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        #region Constructor

        /// <summary>
        /// Inicializa las listas
        /// </summary>
        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.paquetes = new List<Paquete>();
        }

        #endregion

        #region Propiedad

        /// <summary>
        /// Lee/Escribe la lista de paquetes
        /// </summary>
        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set 
            {
                this.paquetes = value;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Finaliza todos los hilos activos
        /// </summary>
        public void FinEntregas()
        {
            foreach (Thread t in this.mockPaquetes)
            {
                if(t.IsAlive == true)
                {
                    t.Abort();
                }
            }
        }

        /// <summary>
        /// Muestra los datos de los paquetes contenidos en el elemnto
        /// </summary>
        /// <param name="elementos">Correo con lista de paquetes</param>
        /// <returns>string con los datos</returns>
        public string MostarDatos(IMostrar<List<Paquete>> elementos)
        {
            Correo paquetes = (Correo)elementos;
            string retorno = "";

            foreach(Paquete p in paquetes.paquetes)
            {
                retorno += string.Format("{0} para {1} ({2})\n", p.TrackingID,p.DireccionEntraega, p.Estado.ToString());
            }

            return retorno;
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Agrega un nuevo paquete a la lista y inicia la simulacion
        /// </summary>
        /// <param name="c">Correo donde agregara el paquete</param>
        /// <param name="p">Paquete a agregar </param>
        /// <returns></returns>
        public static Correo operator +(Correo c, Paquete p)
        {
            Thread thread;
            
            foreach(Paquete paquete in c.paquetes)
            {
                if(paquete == p)
                {
                    throw new TrackingIdRepetidoException("Ya existe el paquete");
                }
            }

            c.paquetes.Add(p);
            thread = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(thread);
            thread.Start();

            return c;
        }

        #endregion

    }
}
