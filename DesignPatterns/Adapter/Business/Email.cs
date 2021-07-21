using System;

namespace lemure.DesignPatterns.Adapter.Business
{
    public class Email
    {
        private readonly string _email;
        public Email(string email)
        {
            _email = email;
        }

        public void Validate()
        {
            if(new Validate().TryValidate(_email))
            {
                Console.WriteLine("Válido!");
            }
            else
            {
                Console.WriteLine("Inválido!");
            }
        }
    }
}