using System;
using MediatR;

namespace Lemure.CQRS.Events;

internal record CreatedBookmarkEvent(Guid BookmarkId, string Title) : INotification;