using System.Collections.Generic;
using Lemure.Infrastructure.DataModel;
using MediatR;

namespace Lemure.CQRS.Queries;

internal record GetBookmarkListQuery() : IRequest<IEnumerable<BookmarkDataModel>>;
