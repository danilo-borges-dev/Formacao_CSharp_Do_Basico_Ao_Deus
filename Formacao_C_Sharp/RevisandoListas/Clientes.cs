namespace RevisandoListas
{
    internal class Clientes
    {
        public string nome { get; set; }
        public int idade { get; set; }

        public Clientes(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
    }
}
