using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Universitario:Persona
    {
        private int legajo;

        #region Constructores

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Universitario()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="legajo">Legajo de un universitario</param>
        /// <param name="nombre">Nombre de un universitario</param>
        /// <param name="apellido">Apellido de un universitario</param>
        /// <param name="dni">DNI de un universitario</param>
        /// <param name="nacionalidad">Nacionalidad de un universitario</param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        #endregion

        //Propiedad publica hecha con el fin de poder serializar el atributo de la clase
        #region Propiedades

        /// <summary>
        /// Lectura/Escritura del legajo de un universitario
        /// </summary>
        public int Legajo 
        { 
            get
            {
                return this.legajo;
            }
            set
            {
                this.legajo = value;
            }    
        }

        #endregion

        #region Metodos

        protected abstract string ParticiparEnClase();

        /// <summary>
        /// Muestra todos los datos de un universitario
        /// </summary>
        /// <returns>Retorna un string con todos los datos del universitario</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.AppendFormat("LEGAJO: {0}\n", this.legajo);

            return sb.ToString();
        }

        /// <summary>
        /// Determina si el objeto especificado es igual al actual
        /// </summary>
        /// <param name="obj">Objeto a comparar</param>
        /// <returns>True igualse / False diferentes</returns>
        public override bool Equals(object obj)
        {
            if (obj is Universitario)
            {
                return (this == (Universitario)obj);
            }
            return false;
        }
        #endregion

        #region Operadores

        public static bool operator ==(Universitario pg1,Universitario pg2)
        {
            if (pg1.GetType() == pg2.GetType() && pg1.DNI == pg2.DNI || pg1.legajo ==pg2.legajo)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        #endregion
    }
}
