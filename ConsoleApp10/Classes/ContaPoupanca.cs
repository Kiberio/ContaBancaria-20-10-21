

namespace ConsoleApp10.Classes
{
    class ContaPoupanca:conta
    {
        public double TaxaJuros{ get; set; }
        //Construtor padrao e com parametro
    public ContaPoupanca() { }
    public ContaPoupanca
            (int numero, string titular, double saldo, double taxaJuros)
            : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros; 
        }
        //Função para atualizar o saldo
    public void atualizacaoSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }
        public override void Saque(double saldoTotal) 
        {
            base.Saque(saldoTotal);
            Saldo -= 2.0;
        }
    }
}
