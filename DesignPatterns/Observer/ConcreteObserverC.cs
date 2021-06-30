using System;
using LeanringWithMosh.DesignPatterns.Observer.Contracts;

namespace LeanringWithMosh.DesignPatterns.Observer
{
    public class ConcreteObserverC : IObserver
    {
        public bool msg { get; set; } = false;
        
        public void Update(ISubject subject)
        {
            Console.WriteLine($"It has reacted an event C {this.msg}\n");
        }
    }
}
