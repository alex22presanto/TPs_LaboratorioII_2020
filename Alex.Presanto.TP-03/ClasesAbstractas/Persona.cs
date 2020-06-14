using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Excepciones;

namespace ClasesAbstractas
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private ENacionalidad nacionalidad;
        private int dni;

        #region Construcotres

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="dni">DNI de la persona (Formato String)</param>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :this(nombre,apellido,nacionalidad)
        {
            this.StringToDNI = dni;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="dni">DNI de la persona (Formato int)</param>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) 
            : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Lectura/Escritura del nombre de la persona
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = this.ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// Lectura/Escritura del apellido de la persona
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = this.ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// Lectura/Escritura del nacionalidad de la persona
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }

        /// <summary>
        /// Lectura/Escritura del DNI de la persona (int)
        /// </summary>
        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = this.ValidarDni(this.nacionalidad, value);
            }
        }

        /// <summary>
        /// Lectura/Escritura del DNI de la persona (String)
        /// </summary>
        public string StringToDNI
        {
            set
            {
                this.dni = this.ValidarDni(this.nacionalidad, value);
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Muestra todos los datos de la persona
        /// </summary>
        /// <returns>Retorna un string con todos los datos de la persona</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(" NOMBRE COMPLETO:{0}, {1}\n", this.Apellido, this.Nombre);
            sb.AppendFormat("NACIONALIDAD: {0}\n", this.nacionalidad.ToString());

            return sb.ToString();
        }

        /// <summary>
        /// Valida un dni con su nacionalidad
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        /// <param name="dni">Dni de la persona</param>
        /// <returns>Retorna un int con el dni validado</returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dni)
        {
            int dniInt;

            if(!int.TryParse(dni,out dniInt))
            {
                throw new DniInvalidoException("Carateres invalidos en el dni");
            }

            return this.ValidarDni(nacionalidad,dniInt);
            
        }

        /// <summary>
        /// Valida un dni con su nacionalidad
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        /// <param name="dni">Dni de la persona</param>
        /// <returns>Retorna un int con el dni validado</returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dni)
        {
            if(nacionalidad == ENacionalidad.Argentino && dni >= 1 && dni <= 89999999)
            {
                return dni;
            }
            else if(nacionalidad == ENacionalidad.Extranjero && dni >= 90000000 && dni <= 99999999)
            {
                return dni;
            }
            else if( dni <1 || dni> 99999999)
            {
                throw new DniInvalidoException("Mas digitos de los validos en el dni");
            }
            throw new NacionalidadInvalidaException("La nacionalidad no coicide con el dni");
        }

        /// <summary>
        /// Valida el nombre/apellido de una persona
        /// </summary>
        /// <param name="dato">Dato a validar</param>
        /// <returns>String validado</returns>
        private string ValidarNombreApellido(string dato)
        {
            Regex r = new Regex("^[a-zA-Z]*$");

            if (r.IsMatch(dato))
            {
                return dato;
            }
            return "";
        }
        
        #endregion

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
    }
}
