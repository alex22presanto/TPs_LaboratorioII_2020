using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta:Vehiculo
    {

        /// <summary>
        ///  Inicilaiza una camioneta
        /// </summary>
        /// <param name="chasis">Codigo del chasis de la camioneta</param>
        /// <param name="marca">Marca de la camioneta</param>
        /// <param name="color">Color de la camioneta</param>
        public Camioneta(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }
        /// <summary>
        /// Las camionetas son grandes
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        /// <summary>
        /// Publica todos los datos de una camioneta.
        /// </summary>
        /// <returns>Retorna una un string con todos los datos</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CAMIONETA");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}\n\n", this.Tamanio);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
