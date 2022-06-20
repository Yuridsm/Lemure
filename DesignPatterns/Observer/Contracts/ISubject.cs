namespace lemure.DesignPatterns.Observer.Contracts
{
    public abstract class ISubject
    {
        // Attach an observer to the subject.
        public abstract void Attach(IObserver observer);
        // Detach an observer from the subject.
        public abstract void Detach(IObserver observer);
        // Notify all observers about an event.
        public abstract void Notify();
        public int State { get; set; } = 0;
        public string name = "";
    }
}
