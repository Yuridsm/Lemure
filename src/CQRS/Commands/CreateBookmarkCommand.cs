using System;
using MediatR;

namespace Lemure.CQRS.Commands;

internal record CreateBookmarkCommand(Guid BookmarkId, string Title, string Description) : IRequest;
