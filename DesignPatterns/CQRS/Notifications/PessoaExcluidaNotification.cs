using MediatR;

namespace Lemure.DesignPatterns.CQRS.Notificaionts
{
    public class PessoaExcluidaNotification : INotification
    {
        public int Id { get; set; }
        public bool IsEfetivado { get; set; }
    }
}