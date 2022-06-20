namespace lemure.DesignPatterns.Adapter.Contracts
{
    public interface IValidatorEmail
    {
        bool TryValidate(string email);
    }
}