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
    }
}
