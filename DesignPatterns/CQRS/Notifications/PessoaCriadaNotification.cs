using MediatR;

namespace Lemure.DesignPatterns.CQRS.Notificaionts
{
    public class PessoaCriadaNotification : INotification
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
    }
}