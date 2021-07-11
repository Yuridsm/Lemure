using System;
using System.Collections.Generic;
using System.Text;

namespace lemure.SOLID.SRP.SRP.Solucao
{
    class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public email Email { get; set; }
        public CPF Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Validar()
        {
            return Email.Validar() && Cpf.Validar();
        }

    }
}
