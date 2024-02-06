using System;
using System.Linq;
using Lemure.OptionalObject.ZoranHorvatExample;
using Lemure.OptionalObject.ZoranHorvatExample.Models;

namespace Lemure.OptionalObject;

public class ZoranHorvatClient
{
    public void Run()
    {
        Person mann = Person.Create("Thomas", "mann");
        Person aristotle = Person.Create("Aristotle", new Address("Rua da Água", "Famosa BH", "Minas Gerais", "Brasil"));

        Book faustus = Book.Create("Doctor Faustus", mann);

        Book rhetoric = Book.Create("Rhetoric", aristotle);
        Book nights = Book.Create("One Thousand and One Nights");

        //var bookshelf = new[] { faustus, rhetoric, nights }
        //    .GroupBy(GetAuthorInitial)
        //    .OrderBy(group => group.Key.Reduce(string.Empty));

        //foreach (var group in bookshelf)
        //{
        //    string header = group.Key.Map(initial => $"[ {initial} ]").Reduce("[ ]");

        //    foreach (var item in group)
        //        Console.WriteLine($"{header} -> {item}");
        //}

        Console.WriteLine(GetSpecificAddress(rhetoric));
    }

    /// <summary>
    /// Tem a responsabilidade de pegar o primeiro caractere de uma string
    /// </summary>
    /// <param name="name">Sua string</param>
    /// <returns></returns>
    public string GetInitial(string name) =>
        name.Length == 0 
            ? string.Empty
            : name.TrimStart().Substring(0, 1).ToUpper();
    
    /// <summary>
    /// Caso o Person tenha firstName e lastName, então pegamos lastLast
    /// Caso contrário, pegamos firstName para assim podemos retornar o
    /// primeiro caractere. Que é uma citação de livro.
    /// 
    /// Exemplo: Yuri Melo -> Melo, Yuri.
    /// 
    /// Com este método, temos:
    /// Melo (sendo o lastName) -> M
    /// </summary>
    /// <param name="person">Objeto pesssoa</param>
    /// <returns></returns>
    public string GetPersonInitial(Person person) =>
        person.LastName
            .Map(GetInitial)
            .Reduce(GetInitial(person.FirstName));
    
    public OptionZoranHorvat<string> GetAuthorInitial(Book book) =>
        book.Author
            .Map(GetPersonInitial);

    // Pegar todos os endereços onde o livro tenha apenas o autor com o primeiro nome;
    #region Example01
    public string GetSpecificAddress(Book book) =>
        book.Author
        .Map(GetAddress)
        .Map(address => $"Street: {GetStreet(address)}; State: {GetState(address)}")
        .Reduce("Não contém informações sobre seu endereço.");

    public OptionZoranHorvat<Address> GetAddress(Person person) => person.Address;

    public string GetStreet(OptionZoranHorvat<Address> address) =>
        address.Map(_ => _.Street).Reduce("Este endereço não contém informação sobre sua rua.");

    public string GetCountry(OptionZoranHorvat<Address> address) =>
        address.Map(_ => _.Country).Reduce("Este endereço não contém informação sobre o seu país.");
    
    public string GetState(OptionZoranHorvat<Address> address) =>
        address.Map(_ => _.State).Reduce("Não tem estado");
    #endregion
}