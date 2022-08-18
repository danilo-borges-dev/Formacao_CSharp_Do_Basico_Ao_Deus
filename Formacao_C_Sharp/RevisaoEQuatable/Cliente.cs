using System;

namespace RevisaoEQuatable
{
    internal class Cliente : IEquatable<Cliente>
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public char sexo { get; set; }

        public Cliente(string nome, int idade, char sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
        }

        public bool Equals(Cliente? other)
        {
            if (this.nome == other.nome)
            {
                return true;
            }
            return false;
        }
    }
}
