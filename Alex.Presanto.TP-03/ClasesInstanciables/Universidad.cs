using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace ClasesInstanciables
{
    public class Universidad
    {
        private List<Alumno> alumnos;
        private List<Jornada> jornadas;
        private List<Profesor> profesores;

        #region Constructor

        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornadas = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }

        #endregion

        #region Propiedades

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

        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornadas;
            }
            set
            {
                this.jornadas = value;
            }
        }

        public List<Profesor> Profesores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        public Jornada this[int i]
        {
            get
            {
                if (i >= 0 && i <= this.jornadas.Count)
                {
                    return this.jornadas[i];
                }
                return null;
            }
            set
            {
                if (i >= 0 && i <= this.jornadas.Count)
                {
                    this.jornadas[i] = value;
                }
            }
        }


        #endregion

        #region Metodos

        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> xml = new Xml<Universidad>();

            if(xml.Guardar(Environment.CurrentDirectory + "Xml.xml", uni))
            {
                return true;
            }
            return false;
        }

        public static Universidad Leer()
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            Universidad uni;

            xml.Leer(Environment.CurrentDirectory + "Xml.xml", out uni);

            return uni;
        }

        private string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach( Alumno a in this.alumnos)
            {
                sb.Append(a.ToString());
            }

            foreach(Profesor p in this.profesores)
            {
                sb.Append(p.ToString());
            }

            foreach(Jornada j in this.jornadas)
            {
                sb.Append(j.ToString());
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region Operadores

        public static bool operator ==(Universidad u , Alumno a)
        {
            foreach(Alumno alumno in u.alumnos)
            {
                if(alumno == a)
                {
                    return true;
                }

            }
            return false;
        }

        public static bool operator ==(Universidad u, Profesor p)
        {
            foreach(Profesor profesor in u.profesores)
            {
                if (profesor == p)
                {
                    return true;
                }
            }
            return false;
        }

        public static Profesor operator ==(Universidad u, EClases c)
        {
            foreach (Profesor profesor in u.profesores)
            {
                if (profesor == c)
                {
                    return profesor;
                }
            }
            throw new SinProfesorException();
        }

        public static bool operator !=(Universidad u, Alumno a)
        {
            return !(u == a);
        }

        public static bool operator !=(Universidad u, Profesor p)
        {
            return !(u == p);
        }

        public static Profesor operator !=(Universidad u, EClases c)
        {
            foreach (Profesor profesor in u.profesores)
            {
                if (profesor != c)
                {
                    return profesor;
                }
            }
            return null;
        }

        public static Universidad operator +(Universidad u, Alumno a)
        {
            if(u != a)
            {
                u.alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            return u;
        }

        public static Universidad operator +(Universidad u, Profesor p)
        {
            if (u != p)
            {
                u.profesores.Add(p);
            }
            return u;
        }

        public static Universidad operator +(Universidad u, EClases c)
        {
            Jornada jornada = new Jornada(c, u == c);

            foreach(Alumno alumno in u.alumnos)
            {
                if(alumno == c)
                {
                    jornada += alumno;
                }
            }
            u.jornadas.Add(jornada);
            return u;
        }

        #endregion

        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
    }
}
