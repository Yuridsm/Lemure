using System;
using System.Threading;
using System.Threading.Tasks;
using Lemure.CQRS.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Lemure.CQRS.Handlers;

internal class CreatedBookmarkHandler : INotificationHandler<CreatedBookmarkEvent>
{
    private readonly ILogger<CreatedBookmarkHandler> _logger;

    public CreatedBookmarkHandler(ILogger<CreatedBookmarkHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(CreatedBookmarkEvent notification, CancellationToken cancellationToken)
	{
        _logger.LogInformation("{@Event} sent at {time}", notification, DateTime.Now);

        return Task.CompletedTask;
	}
}
