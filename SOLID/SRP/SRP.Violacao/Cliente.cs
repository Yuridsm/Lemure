using System;
using System.Collections.Generic;
using System.Text;
/*
namespace lemure.SOLID.SRP.SRP.Violacao
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public string AdicionarCliente()
        {
            if (!Email.Contains(value: "@"))
                return "Cliente com e-mail inválido";

            if (CPF.Length != 11)
                return "Cliente com CPF inválido";

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL, CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, ...";

                cmd.Parameters.AddWithValue(parameterName: "nome", nome);
                cmd.Parameters.AddWithValue(parameterName: "email", email);
                cmd.Parameters.AddWithValue(parameterName: "cpf", cpf);
                cmd.Parameters.AddWithValue(parameterName: "dataCad", dataCad);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            var mail = new MailMessage("empresa@empresa.com", Email);
            var client = new SmtpClient { 
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UserDefaultCredentials = false,
                UriHostNameType = "smtp.google.com"
            };

            mail.Subject = "Bem vindo.";
            mail.Body = "Parabéns! Você está cadasrtado.";
            client.Send(mail);

            return "Cliente cadastrado com sucesso";
        }
    }
}
*/