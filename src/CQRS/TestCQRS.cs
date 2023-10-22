using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lemure.CQRS.Commands;
using Lemure.CQRS.Queries;
using Lemure.Domain.Aggregates;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Lemure.CQRS;

internal class TestCQRS
{
    private readonly ILogger<TestCQRS> _logger;
    private readonly IMediator _mediator;

    public TestCQRS(ILogger<TestCQRS> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    public async Task Run()
	{
		// Domain Object
		var bookmarks = new List<Bookmark>
		{
            new Bookmark("1984", "Descrição do livro '1984' de George Orwell."),
			new Bookmark("Dom Quixote", "Descrição do livro 'Dom Quixote' de Miguel de Cervantes."),
			new Bookmark("O Pequeno Príncipe", "Descrição do livro 'O Pequeno Príncipe' de Antoine de Saint-Exupéry."),
			new Bookmark("Harry Potter e a Pedra Filosofal", "Descrição do livro 'Harry Potter e a Pedra Filosofal' de J.K. Rowling."),
			new Bookmark("Orgulho e Preconceito", "Descrição do livro 'Orgulho e Preconceito' de Jane Austen."),
			new Bookmark("Cem Anos de Solidão", "Descrição do livro 'Cem Anos de Solidão' de Gabriel García Márquez."),
			new Bookmark("A Metamorfose", "Descrição do livro 'A Metamorfose' de Franz Kafka."),
			new Bookmark("Matar um Rouxinol", "Descrição do livro 'Matar um Rouxinol' de Harper Lee."),
			new Bookmark("Crime e Castigo", "Descrição do livro 'Crime e Castigo' de Fyodor Dostoevsky."),
			new Bookmark("O Senhor dos Anéis", "Descrição da trilogia 'O Senhor dos Anéis' de J.R.R. Tolkien."),
			new Bookmark("A Culpa é das Estrelas", "Descrição do livro 'A Culpa é das Estrelas' de John Green."),
			new Bookmark("O Alquimista", "Descrição do livro 'O Alquimista' de Paulo Coelho."),
			new Bookmark("A Revolução dos Bichos", "Descrição do livro 'A Revolução dos Bichos' de George Orwell."),
			new Bookmark("As Crônicas de Nárnia", "Descrição da série 'As Crônicas de Nárnia' de C.S. Lewis."),
			new Bookmark("O Hobbit", "Descrição do livro 'O Hobbit' de J.R.R. Tolkien."),
			new Bookmark("A Arte da Guerra", "Descrição do livro 'A Arte da Guerra' de Sun Tzu."),
			new Bookmark("O Poder do Hábito", "Descrição do livro 'O Poder do Hábito' de Charles Duhigg."),
			new Bookmark("A Cabana", "Descrição do livro 'A Cabana' de William P. Young."),
			new Bookmark("O Silmarillion", "Descrição do livro 'O Silmarillion' de J.R.R. Tolkien."),
			new Bookmark("O Nome do Vento", "Descrição do livro 'O Nome do Vento' de Patrick Rothfuss.")
        };

		foreach (var bookmark in bookmarks)
		{
			var newBookmark = new CreateBookmarkCommand(bookmark.Id, bookmark.Title, bookmark.Description);

            await TestCreateBookmarCommand(_mediator, newBookmark);
		}
		
		// Command & Query Objects
		await TestGetBookmarkListQuery(_mediator);

		await TestGetBookmarkByIdQuery(_mediator, bookmarks.First().Id);
	}

	public async Task TestGetBookmarkListQuery(IMediator mediator)
	{
		Console.WriteLine($"Querying with {nameof(GetBookmarkListQuery)}");
		var bookmarks = await mediator.Send(new GetBookmarkListQuery());

		foreach (var bookmark in bookmarks)
		{
			Console.WriteLine($"\tId: {bookmark.Id} Title: {bookmark.Title} Description: {bookmark.Description}");
		}
	}

	public async Task TestGetBookmarkByIdQuery(IMediator mediator, Guid id)
	{
		Console.WriteLine($"Querying with {nameof(GetBookmarkByIdQuery)}");
		var bookmark = await mediator.Send(new GetBookmarkByIdQuery(id));

		if (bookmark is not null)
			Console.WriteLine($"\tId: {bookmark.Id} Title: {bookmark.Title} Description: {bookmark.Description}");
		else
			Console.WriteLine($"Bookmark does not exist");
	}

	public async Task TestCreateBookmarCommand(IMediator mediator, CreateBookmarkCommand createBookmarkCommand)
	{
		await mediator.Send(createBookmarkCommand);
	}
}
