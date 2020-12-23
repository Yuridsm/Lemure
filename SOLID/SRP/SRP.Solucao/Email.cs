using System;
using System.Collections.Generic;
using System.Text;

namespace LeanringWithMosh.SOLID.SRP.SRP.Solucao
{
    class email
    {
        public string Endereco { get; set; }
        public bool Validar()
        {
            return Endereco.Contains(value: "@");
        }
    }
}
