namespace Genercis_Com_Listas
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }

        public Pessoa()
        {
        }
        public Pessoa(string nome, int idade, char sexo)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
        }

        public void MetodoAumentaIdade(List<Pessoa> listaPessoas)
        {
            foreach (var pessoa in listaPessoas)
            {
                pessoa.Idade++;
            }
        }

        public void Mostrar(List<Pessoa> listaP)
        {
            foreach (var item in listaP)
            {
                Console.WriteLine($"{item.Nome} idade {item.Idade}");
            }
        }
    }
}
