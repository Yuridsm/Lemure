using LeanringWithMosh.DesignPatterns.Observer.Contracts;
using System;

namespace LeanringWithMosh.DesignPatterns.Observer
{
    public class ConcreteObserverA : IObserver
    {
        public bool msg { get; set; } = false;
        public void Update(ISubject subject)
        {
            Console.WriteLine($"It has reacted an event A - {this.msg} - {subject.name}");
            
        }
    }
}
