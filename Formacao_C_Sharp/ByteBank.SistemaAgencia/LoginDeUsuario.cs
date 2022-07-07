using System;

namespace ByteBank.SistemaAgencia
{
    internal class LoginDeUsuario
    {
        private string _senha = "123";

        public void ValidarLogin(string senhaDigitada)
        {
            AutenticacoHelper _autenticar = new AutenticacoHelper();

            if (!_autenticar.Autenticar(_senha, senhaDigitada))
            {
                throw new Exception("Senha inválida!.");
            }
        }
    }
}
