namespace Lemure.TerDorDeCabeca
{
    public class UsarAqui01
    {
        private readonly IAnimal _animal;

        public UsarAqui01(IAnimal animal)
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
