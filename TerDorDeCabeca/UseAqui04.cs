namespace Lemure.TerDorDeCabeca
{
    public class UseAqui04
    {
        private readonly IAnimal _animal;

        public UseAqui04(IAnimal animal)
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
