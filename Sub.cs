using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    class conta {
        public double ValorDolar;
        public double ValorPagamento;

        public double Resultado()
        {
            return (ValorDolar * ValorPagamento);
        }

        public double porcentagem()
        {
            return Resultado() + ((Resultado() * 6) / 100);
        }
        
    }
}
