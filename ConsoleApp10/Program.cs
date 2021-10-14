using System;


namespace ConsoleApp10.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            conta acc = new conta(1001, "Goku", 0.0);
            ContaJuridica bacc = new ContaJuridica(1002, "Goten", 0.0, 500.0);
            //UPCASTING
            conta acc1 = bacc;
            conta acc2 = new ContaJuridica(1003, "Trunks", 0.0, 200.00);
            conta acc3 = new ContaPoupanca(1004, "Vegeta", 0.0, 0.01);

            //DOWNCASTING
            ContaJuridica acc4 = (ContaJuridica)acc2;
            acc4.Emprestimo(100.0);
            if(acc3 is ContaJuridica)
            {
                //ContaPoupancaacc5 = (ContaPoupanca)acc3
                ContaJuridica acc5 = (ContaJuridica)acc3;
                acc5.Emprestimo(200.0);
                Console.WriteLine("Emprestimo!");
            }
            if(acc3 is ContaPoupanca)
            {
                //ContaPoupancaacc5 = (ContaPoupanca)acc3
                ContaPoupanca acc5 = acc3 as ContaPoupanca;
                acc5.atualizacaoSaldo();
                Console.WriteLine("Atualizado!");
            }
            Console.ReadKey();
        }
    }
}

            

