using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp10.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<conta> list = new List<conta>();
            list.Add(new ContaPoupanca(1001, "Terry", 500.0, 0.01));
            list.Add(new ContaJuridica(1002, "Andy", 500.0, 400.0));
            list.Add(new ContaPoupanca(1003, "Joe", 500.0, 0.01));
            list.Add(new ContaJuridica(1002, "Mae", 500.0, 400.0));
            double soma = 0.0;
            foreach (conta acc in list)
            {
                soma += acc.Saldo;
            }
            Console.WriteLine("Total do saldo de todas as contas: " +soma.ToString("F2", CultureInfo.InvariantCulture));
            foreach (conta acc in list)
            {
                acc.Saque(10.0);
            }
            foreach (conta acc in list)
            {
                Console.WriteLine("Atualização do saldo das contas ");
                _ = +acc.Numero + ": " + acc.Saldo.ToString("F2", CultureInfo.InvariantCulture);
            }
            Console.ReadKey();
        }
    }
}

            

