using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Domain.Validations
{
    public class DataValidation
    {
        public static bool NaoPodeSerNula(DateTime? date)
        {
            if (date == null)
                return true;
            return false;
        }

        public static bool NaoPodeSerMaiorQueDataAtual(DateTime? date)
        {
            if (date == null || date > DateTime.Now)
                return true;
            return false;
        }

        public static bool NaoPodeSerMenorQueDataAtual(DateTime? date)
        {
            if (date == null || date < DateTime.Now)
                return true;
            return false;
        }

        public static bool NaoPodeSerDiferenteQueDataAtual(DateTime? date)
        {
            if (date == null || date != DateTime.Now)
                return true;
            return false;
        }
    }

}
