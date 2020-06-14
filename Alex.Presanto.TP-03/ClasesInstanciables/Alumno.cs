using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #region Constructores

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Alumno()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Legajo del alumno</param>
        /// <param name="nombre">Nombre del alumno</param>
        /// <param name="apellido">Apellido del alumno</param>
        /// <param name="dni">DNI del alumno</param>
        /// <param name="nacionalidad">Nacionalidad del alumno</param>
        /// <param name="claseQueToma">Clase que toma el alumno</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            :base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Legajo del alumno</param>
        /// <param name="nombre">Nombre del alumno</param>
        /// <param name="apellido">Apellido del alumno</param>
        /// <param name="dni">DNI del alumno</param>
        /// <param name="nacionalidad">Nacionalidad del alumno</param>
        /// <param name="claseQueToma">Clase que toma el alumno</param>
        /// <param name="estadoCuenta">Estado de Cuenta del alumno</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            :this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        #endregion

        //Propiedades publicas hechas con el fin de poder serializar la clase
        #region Propiedades

        /// <summary>
        /// Lectura/Escritura de la clase que toma del alumno
        /// </summary>
        public Universidad.EClases ClaseQueToma
        {
            get
            {
                return this.claseQueToma;
            }
            set
            {
                this.claseQueToma = value;
            }
        }

        /// <summary>
        /// Lectura/Escritura del estado de cuenta del alumno
        /// </summary>
        public EEstadoCuenta EstadoCuenta 
        {
            get
            {
                return this.estadoCuenta;
            }
            set
            {
                this.estadoCuenta = value;
            }
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Muestra la clase que toma el alumno
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder("TOMA CLASES DE ");
            sb.Append(this.claseQueToma.ToString());

            return sb.ToString();
        }

        /// <summary>
        /// Muestra todos los datos de un alumno de forma privada
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.MostrarDatos());

            sb.AppendLine(this.ParticiparEnClase());
            sb.AppendFormat("ESTADO DE CUENTA: {0}", this.estadoCuenta.ToString());
            return sb.ToString();
        }

        /// <summary>
        /// Muestra todos los datos de un alumno de forma publica
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion

        #region Operadores

        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            if(a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            if (a.claseQueToma != clase)
            {
                return true;
            }
            return false;
        }

        #endregion

        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
    }
}
