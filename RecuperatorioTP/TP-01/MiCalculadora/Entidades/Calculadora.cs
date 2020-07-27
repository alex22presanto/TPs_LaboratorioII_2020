using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        #region Metodos

        /// <summary>
        /// Realiza la operacion de 2 numeros
        /// </summary>
        /// <param name="num1">Primer operador</param>
        /// <param name="num2">Segundo operador</param>
        /// <param name="operador"></param>
        /// <returns>Retorna el resultado de la operacion dada</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;
            switch (Calculadora.ValidarOperador(operador))
            {
                case "+":
                    retorno = num1 + num2;
                    break;
                case "-":
                    retorno = num1 - num2;
                    break;
                case "*":
                    retorno = num1 * num2;
                    break;
                case "/":
                    retorno = num1 / num2;
                    break;
                default:
                    break;

            }
            return retorno;
        }
        /// <summary>
        /// Valida que el operador sea + - * /
        /// </summary>
        /// <param name="operador"> Operador a validar</param>
        /// <returns>Retorna el operador, si no es valido retrona +</returns>
        private static string ValidarOperador(string operador)
        {
            string retorno = "+";
            if (operador == "-" || operador == "*" || operador == "/")
            {
                retorno = operador;
            }
            return retorno;
        }
        #endregion
    }
}
