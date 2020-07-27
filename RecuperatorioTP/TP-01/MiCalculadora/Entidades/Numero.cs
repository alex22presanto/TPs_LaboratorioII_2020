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

        public Numero(): this(0)
        {
        }

        public Numero(double numero) 
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
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
            
            if (Numero.EsBinario(binario))
            {
                for (int i = 0; i < binario.Length; i++)
                {
                    abinario.Enqueue(Convert.ToInt32(binario.Substring(i, 1)));
                }
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
            int numeroInt;
            if (int.TryParse(numero,out numeroInt))
            {
                return Numero.DecimalBinario(numeroInt);
            }
            return "Valor invalido";
        }

        /// <summary>
        /// Valida si el string es binario(compueto por 1 y 0)
        /// </summary>
        /// <param name="binario">Texto a validar</param>
        /// <returns>True si es biario</returns>
        private static bool EsBinario(string binario)
        {
            Queue<int> abinario = new Queue<int>();
            for (int i = 0; i < binario.Length; i++)
            {
                int numero;
                if (int.TryParse(binario.Substring(i, 1), out numero))
                {
                    abinario.Enqueue(numero);
                    
                }
                else
                {
                    return false;
                }
            }
            foreach (int bina in abinario)
            {
                if (bina != 1 && bina != 0)
                {
                    return false;
                }
            }

            return true;
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

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }

        #endregion
    }
}
