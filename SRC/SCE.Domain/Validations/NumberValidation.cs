using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Domain.Validations
{
    public static class NumberValidation
    {
        /// <summary>
        /// Valida se a número inteiro passada é nulo ou não
        /// </summary>
        /// <param name="value">vakor que está sendo validado</param>
        /// <returns>False caso não tenha falhado na validação</returns>
        /// <returns>True caso tenha falhado na validação</returns>
        public static bool InteiroNaoPodeSerNulo(int? value)
        {
            if (value == null)
                return true;
            return false;
        }
    }
}
