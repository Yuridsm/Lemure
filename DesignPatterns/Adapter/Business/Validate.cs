using lemure.DesignPatterns.Adapter.Contracts;

namespace lemure.DesignPatterns.Adapter.Business
{
    public class Validate : IValidatorEmail
    {
        public bool TryValidate(string email) {
            // Faz as validações
            return true;
        }
    }
}