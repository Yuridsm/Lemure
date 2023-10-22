using lemure.DesignPatterns.Observer;
using lemure.DesignPatterns.Observer.Contracts;

namespace Lemure.DesignPatterns.Observer;

internal class ObserverClient
{
	static readonly ISubject subject = new Subject();

	static IObserver concreteA = new ConcreteObserverA();
	static IObserver concreteB = new ConcreteObserverB();
	static IObserver concreteC = new ConcreteObserverC();

	public static void Run()
	{
		subject.Attach(concreteA);
		subject.Attach(concreteB);
		subject.Attach(concreteC);

		subject.State = 90;
		subject.Notify();
	}
}
