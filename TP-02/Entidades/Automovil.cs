using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Automovil:Vehiculo
    {
        private ETipo tipo;


        #region Enumerado

        public enum ETipo 
        { 
            Monovolumen, Sedan
        }

        #endregion

        #region Constructores

        /// <summary>
        ///  Inicializa un auto. Por defecto, TIPO será Monovolumen
        /// </summary>
        /// <param name="marca">Marca del auto</param>
        /// <param name="chasis">Codigo del chasis del auto</param>
        /// <param name="color">Color del auto</param>
        public Automovil(EMarca marca, string chasis, ConsoleColor color)
            : this(marca, chasis, color, ETipo.Monovolumen)
        {
        
        }

        /// <summary>
        ///  Inicilaiza un auto
        /// </summary>
        /// <param name="marca">Marca del auto</param>
        /// <param name="chasis">Codigo del chasis del auto</param>
        /// <param name="color">Color del auto</param>
        /// <param name="tipo">Tipo del auto</param>
        public Automovil(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }
        #endregion

        #region Propiedad

        /// <summary>
        /// Los automoviles son medianos
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        #endregion

        #region Metodo

        /// <summary>
        /// Publica todos los datos de un auto.
        /// </summary>
        /// <returns>Retorna una un string con todos los datos</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("AUTOMOVIL");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}\n", this.Tamanio.ToString());
            sb.AppendFormat("TIPO : {0}\n\n", this.tipo.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
