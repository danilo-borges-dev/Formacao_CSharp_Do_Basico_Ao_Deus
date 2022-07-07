using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    internal class AutenticacoHelper
    {
        public bool Autenticar(string senhaLogin, string senhaDigitada) => (senhaLogin == senhaDigitada) ? true : false;
    }
}
