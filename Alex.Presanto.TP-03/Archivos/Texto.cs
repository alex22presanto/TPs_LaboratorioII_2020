using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Guarda los datos en formato .txt
        /// </summary>
        /// <param name="archivo">PATH donde se guardara</param>
        /// <param name="dato">texto a guardar</param>
        /// <returns>True Guardo dato / False ocurrio un error</returns>
        public bool Guardar(string archivo, string dato)
        {
            StreamWriter writer= null;
            bool flag = false;

            try
            {
                writer = new StreamWriter(archivo);
                writer.WriteLine(dato);
                flag = true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
            return flag;
        }

        /// <summary>
        /// lee los datos en formato .txt
        /// </summary>
        /// <param name="archivo">PATH donde se leera</param>
        /// <param name="dato">Referencia de variable string donde se guardara el texto leeido</param>
        /// <returns>True leyo dato correctamente / False ocurrio un error</returns>
        public bool Leer(string archivo, out string dato)
        {
            StreamReader reader = null;
            bool flag = false;

            try
            {
                reader = new StreamReader(archivo);
                dato = reader.ReadToEnd();
                flag = true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return flag;
        }
    }
}
