namespace lemure.DesignPatterns.Builder
{
    using lemure.DesignPatterns.Builder.Domain.ValueObject;

    public class Pizza
    {
        public string Sabor { get; set; }
        public Borda Borda { get; set; }
        public double Valor { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public PizzaType PizzaType { get; set; }
        public IngrediantesType IngrediantesType { get; set; }
        public int TempoFornoMin { get; set; }
    }
}