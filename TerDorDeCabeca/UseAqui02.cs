namespace Lemure.TerDorDeCabeca
{
    public class UseAqui02
    {
        private readonly IAnimal _animal;

        public UseAqui02(IAnimal animal)
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
