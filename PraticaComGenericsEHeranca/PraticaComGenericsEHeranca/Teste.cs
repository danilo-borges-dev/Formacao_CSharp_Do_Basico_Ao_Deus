namespace PraticaComGenericsEHeranca
{
    internal class Teste
    {
        private void Testar()
        {
            var dog = new Cachorro() { Nome = "Toy", Patas = 4, MesesGestacao = 3, Especie = "Cachorro" };
            //IPet<Animal> p1 = new Pet<Cachorro>();
        }
    }
}
