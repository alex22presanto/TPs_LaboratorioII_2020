using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace ClasesInstanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        #region Constructores

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clase">Tipo de clase que va a ser la jornada</param>
        /// <param name="instructor">Insturcto / profesor que va a dar la clase</param>
        public Jornada(Universidad.EClases clase, Profesor instructor)
            :this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        #endregion

        //Propiedades publicas hechas con el fin de poder serializar la clase
        #region Propiedades

        /// <summary>
        /// Lectura/Escritura lista de alumnos que toman la clase
        /// </summary>
        public List<Alumno> Alumnos 
        { 
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        /// <summary>
        /// Lectura/Escritura tipo de clase que es la jornada
        /// </summary>
        public Universidad.EClases Clases 
        { 
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }

        /// <summary>
        /// Lectura/Escritura del instructor / profesor que da la clase
        /// </summary>
        public Profesor Instructor 
        { 
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Gurda un jornada como texto
        /// </summary>
        /// <param name="jornada">Jornada a guardar</param>
        /// <returns>True Guardo jornada / False ocurrio un error</returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto texto = new Texto();
            if(texto.Guardar(Environment.CurrentDirectory + "Texto.txt", jornada.ToString()))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Lee una jornada
        /// </summary>
        /// <returns>string con la jornada leeida</returns>
        public static string Leer()
        {
            Texto texto = new Texto();
            string retorno;

            texto.Leer(Environment.CurrentDirectory + "Texto.txt", out retorno);

            return retorno;
        }

        /// <summary>
        /// Muestra todos los datos de una jornada de forma publica
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CLASE DE: {0}\n", clase.ToString());
            sb.AppendFormat("POR: {0}\n", instructor.ToString());
            sb.AppendLine("ALUMNOS:");
            foreach(Alumno alumno in this.alumnos)
            {
                sb.AppendLine(alumno.ToString());
            }

            return sb.ToString();
        }

        #endregion

        #region Operadores

        public static bool operator ==(Jornada j,Alumno a)
        {
            foreach(Alumno alumno in j.alumnos)
            {
                if ( alumno == a)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            if(j != a)
            {
                j.alumnos.Add(a);
            }
            return j;
        }
        #endregion
    }
}
