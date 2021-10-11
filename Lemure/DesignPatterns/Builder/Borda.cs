namespace lemure.DesignPatterns.Builder
{
    using Lemure.DesignPatterns.Builder.Domain.ValueObject;

    public class Borda
    {
        public BordaType BordaType { get; set; }
        public BordaSize BordaSize { get; set; }
    }
}