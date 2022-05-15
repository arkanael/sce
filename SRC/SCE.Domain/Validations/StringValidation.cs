using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Domain.Validations
{
    public static class StringValidation
    {
        /// <summary>
        /// Valida se a string passada é nulo ou não
        /// </summary>
        /// <param name="descricao">Nome que está sendo validado</param>
        /// <param name="maxLenght">Quantidade máxima de caracteres permitido</param>
        /// <returns>False caso não tenha falhado na validação</returns>
        /// <returns>True caso tenha falhado na validação</returns>
        public static bool NaoPodeSerNulo(string value)
        {
            if (value == null)
                return true;
            return false;
        }

        /// <summary>
        /// Verifica a quantidade mínima permitida para a validação da string
        /// </summary>
        /// <param name="value">Nome que está sendo validado</param>
        /// <param name="maxLenght">Quantidade máxima de caracteres permitido</param>
        /// <returns>False caso não tenha falhado na validação</returns>
        /// <returns>True caso tenha falhado na validação</returns>
        public static bool QuantidadeMinimaCaracteres(string value, short minLenght)
        {
            if (string.IsNullOrEmpty(value) || value.Length < minLenght)
                return true;
            return false;

        }

        /// <summary>
        /// Verifica a quantidade máxima permitida para a validação do nome
        /// </summary>
        /// <param name="value">Nome que está sendo validado</param>
        /// <param name="maxLenght">Quantidade máxima de caracteres permitido</param>
        /// <returns>False caso não tenha falhado na validação</returns>
        /// <returns>True caso tenha falhado na validação</returns>
        public static bool QuantidadeMaximaCaracteres(string value, short maxLenght)
        {
            if (string.IsNullOrEmpty(value) || (value.Length > maxLenght))
                return true;
            return false;
        }

        /// <summary>
        /// Verifica se o texto é igual ao texto comparado 
        /// </summary>
        /// <param name="value">Texto</param>
        /// <param name="valueCompared">Texto a ser comparado</param>
        /// <returns>Retorna true se os textos forem iguais, vazio e ou nulo.</returns>
        /// <returns>Retorna false se os textos não forem iguais.</returns>
        public static bool NaoPodeSerIgual(string value, string valueCompared)
        {
            if (string.IsNullOrEmpty(value) || (value == valueCompared))
                return true;
            return false;
        }
    }
}
