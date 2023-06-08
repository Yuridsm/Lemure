using MediatR;

namespace Lemure.DesignPatterns.CQRS.Notificaionts
{
    public class ErroNotification : INotification
    {
        public string Excecao { get; set; }
        public string PilhaErro { get; set; }
    }
}