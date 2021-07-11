using System;
using System.Collections.Generic;
using System.Text;

namespace lemure.SOLID.OCP.OCP.Solucao_Extension_Methods
{
    public static class DebitoContaPoupanca
    {
        public static string DebitarContaPoupanca(this DebitoConta debitoConta)
        {
            return debitoConta.FormatarTransacao();
        }
    }
}
