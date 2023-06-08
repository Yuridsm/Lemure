using System;
using System.Reflection;
using Lemure.DesignPatterns.CQRS.Commands;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Lemure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection()
                .AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()))
                .BuildServiceProvider();

            var mediator = serviceCollection.GetRequiredService<IMediator>();

            var command = new CadastraPessoaCommand();

            var notification = mediator.Send(command);
            Console.WriteLine(notification);
        }
    }
}
