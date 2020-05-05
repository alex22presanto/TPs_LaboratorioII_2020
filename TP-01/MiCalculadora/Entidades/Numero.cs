using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        #region Setter
        private string SetNumero
        {
            set
            {
                this.numero = Numero.ValidarNumero(value);
            }
        }
        #endregion

        #region Constructores
        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero) : this(Convert.ToString(numero))
        {
        }

        public Numero(string strNumero) : this()
        {
            this.SetNumero = strNumero;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Convierte de binario a decimal
        /// </summary>
        /// <param name="binario">Numero binario a converitir</param>
        /// <returns>Retorna el valor decimal</returns>
        public static string BinarioDecimal(string binario)
        {
            Queue<int> abinario = new Queue<int>();
            double resultado = 0;
            bool esBinario = true;
            for (int i = 0; i < binario.Length; i++)
            {
                abinario.Enqueue(Convert.ToInt32(binario.Substring(i, 1)));
            }
            foreach (int bina in abinario)
            {
                if (bina != 1 && bina != 0)
                {
                     esBinario = false;
                }
            }
            if (esBinario == true)
            {
                do
                {

                    if (abinario.Dequeue() == 1)
                    {
                        resultado += Math.Pow(2, abinario.Count);
                    }

                } while (abinario.Count != 0);
                return Convert.ToString(resultado);
            }
            else
            {
                return "Valor invalido";
            }
        }

        /// <summary>
        /// Convierte de deciam a binario
        /// </summary>
        /// <param name="numero">Numero a convertir</param>
        /// <returns>retorna el valor binario </returns>
        public static string DecimalBinario(double numero)
        {
            Stack<double> binario = new Stack<Double>();
            int num = Convert.ToInt32(numero);
            //string retorno;
            string retorno = "1";
            do
            {
                binario.Push(num % 2);
                num /= 2;
            } while (num >= 2);
            for (int i = binario.Count; i > 0; i--)
            {
                retorno += Convert.ToString(binario.Pop());
            }

            return retorno;
        }

        /// <summary>
        /// Convierte de deciam a binario
        /// </summary>
        /// <param name="numero">Numero a convertir</param>
        /// <returns>retorna el valor binario </returns>
        public static string DecimalBinario(string numero)
        {

            if (ValidarNumero(numero) != 0)
            {
                return Numero.DecimalBinario(ValidarNumero(numero));
            }
            return "Valor invalido";
        }

        /// <summary>
        /// Valida un numero y lo convierte a double
        /// </summary>
        /// <param name="strNumero">Numero a validar y convertir</param>
        /// <returns>Retorna el numero validado y convertido</returns>
        private static double ValidarNumero(string strNumero)
        {
            double retorno;
            if (!double.TryParse(strNumero, out retorno))
            {
                retorno = 0;
            }
            return retorno;
        }
        #endregion

        #region Operadores

        public static Double operator +(Numero n1, Numero n2)
        {
            double retrono = n1.numero + n2.numero;
            return retrono;
        }

        public static Double operator -(Numero n1, Numero n2)
        {
            double retrono = n1.numero - n2.numero;
            return retrono;
        }

        public static Double operator *(Numero n1, Numero n2)
        {
            double retrono = n1.numero * n2.numero;
            return retrono;
        }

        public static Double operator /(Numero n1, Numero n2)
        {
            double retrono;
            if (n2.numero == 0)
            {
                retrono = double.MinValue;
            }
            else
            {
                retrono = n1.numero / n2.numero;
            }
            return retrono;
        }

        #endregion
    }
}
