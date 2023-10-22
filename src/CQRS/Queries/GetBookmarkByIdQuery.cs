using System;
using Lemure.Infrastructure.DataModel;
using MediatR;

namespace Lemure.CQRS.Queries;

internal record GetBookmarkByIdQuery(Guid Id) : IRequest<BookmarkDataModel>;
