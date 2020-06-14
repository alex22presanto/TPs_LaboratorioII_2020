using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException:Exception
    {
        public DniInvalidoException():this("Dni Invalido")
        {

        }

        public DniInvalidoException(Exception e):this("Dni Invalido",e)
        {

        }

        public DniInvalidoException(string message):base(message)
        {

        }

        public DniInvalidoException(string message, Exception e):base(message,e)
        {

        }
    }
}
