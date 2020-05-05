using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto:Vehiculo
    {
        /// <summary>
        ///  Inicilaiza una moto
        /// </summary>
        /// <param name="chasis">Codigo del chasis de la moto</param>
        /// <param name="marca">Marca de la moto</param>
        /// <param name="color">Color de la moto</param>
        public Moto(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis,marca,color)
        {
        }

        /// <summary>
        /// Las motos son chicas
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }


        /// <summary>
        /// Publica todos los datos de una moto.
        /// </summary>
        /// <returns>Retorna una un string con todos los datos</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOTO");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}\n\n", this.Tamanio.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
