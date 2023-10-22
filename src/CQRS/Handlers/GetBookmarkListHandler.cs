using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Lemure.CQRS.Queries;
using Lemure.Infrastructure.DataModel;
using Lemure.Infrastructure.Mapping;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Lemure.CQRS.Handlers;

internal class GetBookmarkListHandler : IRequestHandler<GetBookmarkListQuery, IEnumerable<BookmarkDataModel>>
{
	private readonly IBookmarkRepository _bookmarkRepository;
    private readonly ILogger<GetBookmarkListHandler> _logger;

    public GetBookmarkListHandler(IBookmarkRepository bookmarkRepository, ILogger<GetBookmarkListHandler> logger)
    {
		_bookmarkRepository = bookmarkRepository;
        _logger = logger;
    }

    public Task<IEnumerable<BookmarkDataModel>> Handle(GetBookmarkListQuery request, CancellationToken cancellationToken)
	{
		var bookmarks = _bookmarkRepository.GetBookmarks();

        var dataModel = BookmarkMapping.MapToDataModel(bookmarks);
        
        _logger.LogInformation("{@GetBookmarkListQuery} sent at {time}. DataModel: {@DataModel}", request, DateTime.Now, dataModel.ToList());

        return Task.FromResult(dataModel);
	}
}
