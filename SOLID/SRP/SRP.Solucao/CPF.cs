using System;
using System.Collections.Generic;
using System.Text;

namespace LeanringWithMosh.SOLID.SRP.SRP.Solucao
{
    class CPF
    {
        public string Numero { get; set; }

        public bool Validar()
        {
            return Numero.Length == 11;
        }
    }
}
