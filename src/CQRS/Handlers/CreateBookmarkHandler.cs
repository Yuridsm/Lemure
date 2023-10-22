using System;
using System.Threading;
using System.Threading.Tasks;
using Lemure.CQRS.Commands;
using Lemure.CQRS.Events;
using Lemure.Infrastructure.Mapping;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Lemure.CQRS.Handlers;

internal class CreateBookmarkHandler : IRequestHandler<CreateBookmarkCommand>
{
	private readonly IMediator _mediator;
	private readonly IBookmarkRepository _bookmarkRepository;
    private readonly ILogger<CreateBookmarkHandler> _logger;

    public CreateBookmarkHandler(IMediator mediator, IBookmarkRepository bookmarkRepository, ILogger<CreateBookmarkHandler> logger)
	{
		_mediator = mediator;
		_bookmarkRepository = bookmarkRepository;
        _logger = logger;
    }

	public Task Handle(CreateBookmarkCommand request, CancellationToken cancellationToken)
	{
		var bookmark = new Domain.Aggregates.Bookmark(request.BookmarkId, request.Title, request.Description);

        _bookmarkRepository.Create(bookmark);

        _logger.LogInformation("{@CreateBookmarkCommand} sent at {time}", request, DateTime.Now);

        var bookmarkCreated = new CreatedBookmarkEvent(bookmark.Id, bookmark.Description);

        _mediator.Publish(bookmarkCreated);

        return Task.CompletedTask;
	}
}
