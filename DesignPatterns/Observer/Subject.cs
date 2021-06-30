using System;
using System.Collections.Generic;
using LeanringWithMosh.DesignPatterns.Observer.Contracts;

namespace LeanringWithMosh.DesignPatterns.Observer
{
    public class Subject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public override void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
        }

        public override void Detach(IObserver observer)
        {
            Console.WriteLine("Subject: Detached an observer.");
            this._observers.Remove(observer);
        }

        public override void Notify()
        {
            //Console.WriteLine("Subject: Notifying observers...");
            foreach(var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nApplying business role!");
            this.State = new Random().Next(0, 10);
            this.Notify();
        }

        public void MessageMe()
        {
            foreach(IObserver observer in _observers)
            {
                observer.msg = true;
            }
            this.Notify();
        }
    }
}
