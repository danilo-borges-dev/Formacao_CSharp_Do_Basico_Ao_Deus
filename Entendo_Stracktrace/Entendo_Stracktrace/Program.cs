using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entendo_Stracktrace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account(0);
            try
            {
                ac.Transfer(100);
            }
            catch (BalanceException ex)
            {
                Console.WriteLine(ex.ToString());
                //Console.WriteLine(ex.StackTrace);
            }
            

            Console.ReadLine();
        }
    }

    internal class Account
    {
        private double _balance;

        public Account(double value)
        {
            _balance = value;
        }

        public void ToWithdraw(double value)
        {
            try
            {
                if (value > _balance)
                {
                    throw new BalanceException(_balance);
                }
            }
            catch (BalanceException ex)
            {
                throw;
            }
        }

        public void Transfer(double value)
        {
            try
            {
                ToWithdraw(value);  // Saca o valor da conta para transferir para conta destino
            }
            catch (BalanceException ex)
            {
                throw;
            }
        }
    }

}
internal class BalanceException : Exception
{
    private double _balance;

    public BalanceException(double value) : this($"Você não possui saldo na conta bancária. Você está tentando sacar um valor de R$ {value}")
    {
        this._balance = value;
    }

    public BalanceException(string message) : base(message)
    {

    }
}

