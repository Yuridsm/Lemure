namespace LeanringWithMosh.DesignPatterns.Observer.Contracts
{
    public interface IObserver
    {
        void Update(ISubject subject);
        bool msg { get; set; }
    }
}
