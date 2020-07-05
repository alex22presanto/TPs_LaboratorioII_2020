using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    public interface IMostrar<T>
    {
        string MostarDatos(IMostrar<T> elemento);
    }
}
