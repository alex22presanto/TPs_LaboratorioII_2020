﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExtencionString
{
    public static class GuardarString
    {
        public static bool Guardar(this string texto, string archivo)
        {
            StreamWriter writer = null;
            bool flag = false;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//" + archivo;

            try
            {
                writer = new StreamWriter(path,true);
                writer.WriteLine(texto);
                flag = true;
            }
            catch (Exception ex)
            {
                throw ex;
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
    }
}