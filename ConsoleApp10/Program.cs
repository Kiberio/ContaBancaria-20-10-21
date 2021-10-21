using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp10.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação da lista com as contas bacarias
            List<conta> list = new List<conta>();
            list.Add(new ContaPoupanca(1001, "Terry", 500.0, 0.01));
            list.Add(new ContaJuridica(1002, "Andy", 500.0, 400.0));
            list.Add(new ContaPoupanca(1003, "Joe", 500.0, 0.01));
            list.Add(new ContaJuridica(1002, "Mae", 500.0, 400.0));
            //Declarando a variavel soma
            double soma = 0.0;
            //foreach para somar o saldo de todas as contas
            foreach (conta acc in list)
            {
                soma += acc.Saldo;
            }
            //Imprimir saldo total
            Console.WriteLine("Total do saldo de todas as contas: " +soma.ToString("F2", CultureInfo.InvariantCulture));
            //sacando 10 de cada conta
            foreach (conta acc in list)
            {
                acc.Saque(10.0);
            }
            //Atualizar o saldo das contas
            foreach (conta acc in list)
            {
                Console.WriteLine("Atualização do saldo das contas ");
                _ = +acc.Numero + ": " + acc.Saldo.ToString("F2", CultureInfo.InvariantCulture);
            }
            Console.ReadKey();
        }
    }
}

            

