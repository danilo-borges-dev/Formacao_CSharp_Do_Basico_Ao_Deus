using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendoDLLs
{
    internal class ContaCorrente
    {
        public int Id { get; set; }
        public int Number { get; set; }

        /// <summary>
        /// Construtor da classe ContaCorrente, você precisa popular os parêmtros de entrada <see cref="Id"/> e <see cref="Number"/>
        /// </summary>
        /// <param name="id"></param>
        /// <param name="number"></param>
        public ContaCorrente(int id, int number)
        {
            Id = id;
            Number = number;
        }
    }
}
