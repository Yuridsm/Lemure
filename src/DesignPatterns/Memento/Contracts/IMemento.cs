using System;

namespace Lemure.DesignPatterns.Memento.Contracts;

public interface IMemento
{
	string GetName();
	DateTime GetDate();
}
