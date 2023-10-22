using System;
using Lemure.DesignPatterns.Memento.Contracts;

namespace Lemure.DesignPatterns.Memento.Concretes;

public class ConcreteMemento : IMemento
{
	private string _name;
	private DateTime _dateTime;
	private string _filePath;
	private string _fileFormat;

	public static ConcreteMemento Create(string name, DateTime dateTime, string filePath, string fileFormat)
	{
		ConcreteMemento concreteMemento = new ConcreteMemento();
		concreteMemento._name = name;
		concreteMemento._dateTime = dateTime;
		concreteMemento._filePath = filePath;
		concreteMemento._fileFormat = fileFormat;
		return concreteMemento;
	}

	public string GetName() => _name;
	public DateTime GetDate() => _dateTime;
	public string GetFilePath() => _filePath;
	public string GetFileFormat() => _fileFormat;
}
