using System;
using System.Threading;
using System.Threading.Tasks;
using Lemure.CQRS.Queries;
using Lemure.Infrastructure.DataModel;
using Lemure.Infrastructure.Mapping;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Lemure.CQRS.Handlers;

internal class GetBookmarkByIdHandler : IRequestHandler<GetBookmarkByIdQuery, BookmarkDataModel>
{
	private readonly IBookmarkRepository _bookmarkRepository;
    private readonly ILogger<GetBookmarkByIdHandler> _logger;

    public GetBookmarkByIdHandler(IBookmarkRepository bookmarkRepository, ILogger<GetBookmarkByIdHandler> logger)
    {
		_bookmarkRepository = bookmarkRepository;
        _logger = logger;
    }

    public Task<BookmarkDataModel> Handle(GetBookmarkByIdQuery request, CancellationToken cancellationToken)
	{
		var bookmark = _bookmarkRepository.Filter(o => o.Id == request.Id);

		if (bookmark is null) throw new Exception($"The bookmark does not exist.");

        var dataModel = BookmarkMapping.MapToDataModel(bookmark);
        
        _logger.LogInformation("{@GetBookmarkByIdQuery} sent at {time}.", request, DateTime.Now);

        return Task.FromResult(dataModel);
	}
}
