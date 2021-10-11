using lemure.DesignPatterns.Builder.Domain.ValueObject;

namespace lemure.DesignPatterns.Builder.Contracts
{
    public interface IPizzaBuilder
    {
        void PrepararABorda(Borda borda);
        void PararAMassa(PizzaSize pizzaSize);
        void InsereIngrediantes();
        void DefinirValor();
        void TempoForno();
        Pizza GetPizza();
    }
}