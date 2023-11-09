using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseeObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Não Seguro
            House house1 = new House();
            house1.Address = "Rua xyz,123";
            house1.Color = "Verde";

            House house2 = new House();
            house2.Address = "Rua abc,456";
            house2.Color = "Vermelho";

            //Seguro
            BankAccount bankAccount = new BankAccount(personName: "Nicolas");

            bankAccount.Deposit(amount: 100);
            bankAccount.WithDraw(amount: 50);
            bankAccount.ShowDetails();

            Console.WriteLine(bankAccount.Balance);
        }
    }

    public class House
    {
        public string Address;
        public string Color;

        public void TurnLighOn()
        {
            Console.WriteLine(value: "Luzes Ligadas");

        }
        public void TurnLighOff()
        {
            Console.WriteLine(value: "Luzes Desligadas");
        }
    }

    public class BankAccount
    {
        private string personName;
        private decimal balance;

        //public decimal Balance { get { return balance; } }
        //OU
        public decimal Balance => balance;
        public BankAccount(string personName)
        {
            this.personName = personName;
        }
        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void WithDraw(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Saldo Insuficiente");
                return;
            }
            balance -= amount;
        }

        public void ShowDetails()
        {
            Console.WriteLine(value: $"{personName} possui saldo de {balance:C2}");
        }
    }
}
