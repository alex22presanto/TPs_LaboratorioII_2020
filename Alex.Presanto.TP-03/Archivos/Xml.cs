using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T> where T : new()
    {
        /// <summary>
        /// Guarda los datos en formato .xml
        /// </summary>
        /// <param name="archivo">PATH donde se guardara</param>
        /// <param name="dato">dato de tipo T a guardar</param>
        /// <returns>True Guardo dato / False ocurrio un error</returns>
        public bool Guardar(string archivo, T dato)
        {
            bool flag = false;
            XmlTextWriter writer = null;

            try
            {
                writer = new XmlTextWriter(archivo, Encoding.GetEncoding("ISO-8859-1"));
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, dato);
                flag = true;
            }
            catch(Exception ex)
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
        /// lee los datos en formato .xml
        /// </summary>
        /// <param name="archivo">PATH donde se leera</param>
        /// <param name="dato">Referencia de variable T donde se guardara el texto leeido</param>
        /// <returns>True leyo dato correctamente / False ocurrio un error</returns>
        public bool Leer(string archivo, out T dato)
        {
            XmlTextReader reader=null;
            bool flag = false;

            try
            {
                reader = new XmlTextReader(archivo);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                dato = new T();
                dato = (T)serializer.Deserialize(reader);
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
