namespace PraticaComGenerics
{
    internal class Lista<T>
    {         // int
        private No<T> _primeiro;
                           // int
        public void Adicionar(T elemento) // O método Adicionar possui um parâmetro de entrada do tipo objecte, portanto recebe a referência de um objeto (Reference Type)
        {// nome da Classe
            No<T> novoNo = new();  // Aqui eu instanciei um objeto do Tipo No
                                // int
            novoNo.Elemento = elemento;  // Aqui passo a referência recebido por parâmetro em Adicionar para a propriedade Elemento existente no objeto No

            if (_primeiro == null)  // Verificar se o valor da propriedade _primeiro é null, e na primeira interação sim, será null
            {
                _primeiro = novoNo; // Agora a propriedade _primeiro está armazendo a referência do objeto novoNo, agora está propriedade está apontado para o objeto novoNo
            }
            else
            {// int
                No<T> no = _primeiro;  // A partir da segunda intereção com este método, está variável no do Tipo No passa a armazenar a referência de _primeiro
                while (no.Proximo != null) // Enquanto a propriedade do objeto no.Proximo for diferente de null faça
                {
                    no = no.Proximo; // a variável no recebe o valor que existe na propriedade Proximo do objeto instanciado no
                }
                no.Proximo = novoNo;  // Nesta posição a propriedade de no.Proximo passa a armazenar a referência para o objeto instanciado novoNo
            }
        }
             // int
        public T Ler(int pos) // O método Ler recebe a posição passada por parâmetro
        {
            if (pos < 0)  // A posição passada por parâmetro ser menor do que 0 retorna null
            {
                return default(T);
            }
            if (_primeiro == null) // Na primeira integração _primeiro vale null, portanto na primeira integração irá retornar null
            {
                return default(T);
            }
            int count = 0;
        // int
            No<T> no = _primeiro;

            while(count < pos)
            {
                no = no.Proximo;
                count++;
            }
            return no.Elemento;
        }
    }
}
