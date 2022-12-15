namespace Lemure.TerDorDeCabeca
{
    public class UseAqui03
    {
        private readonly IAnimal _animal;

        public UseAqui03(IAnimal animal)
        {
            _animal = animal;
        }

        public void FazerUmAnimalAndar()
        {
            _animal.Andar();
        }

        public void FazerUmAnimalComer()
        {
            _animal.Comer();
        }
    }
}
