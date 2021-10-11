namespace lemure.DesignPatterns.Builder.Contracts
{
    public abstract class PizzaBuilderBase
    {
        protected Pizza Pizza = null;
        protected readonly ICalculaValor _calculaValor;

        protected PizzaBuilderBase(ICalculaValor CalculaValor)
        {
            _calculaValor = CalculaValor;
        }

        public virtual void DefineValor()
        {
            _calculaValor.DefineValor(Pizza);
        }

        public Pizza GetPizza()
        {
            return Pizza;
        }

        protected void Init()
        {
            Pizza = new Pizza();
        }
    }
}