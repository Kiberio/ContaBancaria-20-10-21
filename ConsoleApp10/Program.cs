using System;


namespace ConsoleApp10.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inserindo dados da conta bancaria
            ContaJuridica contaJuridicaconta = new ContaJuridica(8010,"LaraCroft", 100.0, 500.0);
            //Mostrando o saldo da conta
            Console.WriteLine(value:contaJuridicaconta.Saldo);
            Console.ReadKey();
        }
    }
}
