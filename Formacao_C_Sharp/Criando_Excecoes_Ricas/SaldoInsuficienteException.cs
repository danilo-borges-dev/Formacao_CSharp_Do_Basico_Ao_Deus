using System;

namespace Criando_Excecoes_Ricas
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException() { }
        public SaldoInsuficienteException(string message) : base("Saldo insuficiente.") { }
        public SaldoInsuficienteException(string message, Exception inner) : base(message, inner) { }
    }
}
