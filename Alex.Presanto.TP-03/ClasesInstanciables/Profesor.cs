using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        #region Constructores

        static Profesor()
        {
            random = new Random();
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Profesor()
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Legajo del alumno</param>
        /// <param name="nombre">Nombre del alumno</param>
        /// <param name="apellido">Apellido del alumno</param>
        /// <param name="dni">DNI del alumno</param>
        /// <param name="nacionalidad">Nacionalidad del alumno</param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(id,nombre,apellido,dni,nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this.randomClases();
            this.randomClases();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Agerga un tipo de clase que puede dar el profesor de forma random
        /// </summary>
        private void randomClases()
        {
            this.clasesDelDia.Enqueue((Universidad.EClases) random.Next(0, 3));
        }

        /// <summary>
        /// Muestra la clase que da el Profesor
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder("CLASES DEL DÍA ");
            foreach (Universidad.EClases clases in this.clasesDelDia)
            {
                sb.AppendLine(clases.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Muestra todos los datos de un Profesor de forma privada
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.MostrarDatos());

            sb.Append(this.ParticiparEnClase());

            return sb.ToString();
        }

        /// <summary>
        /// Muestra todos los datos de un Profesor de forma publica
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion

        #region Operdores

        public static bool operator ==(Profesor p, Universidad.EClases clase)
        {
            foreach (Universidad.EClases c in p.clasesDelDia)
            {
                if(c == clase)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Profesor p, Universidad.EClases clase)
        {
            return !(p == clase);
        }
        #endregion
    }
}
