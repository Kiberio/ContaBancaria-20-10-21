using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Classes
{
    class conta
    {
        //Declarações das variáveis e uso do encapsulamento
        public int Numero { get; private set;}
        public string Titular { get; private set;}
        //Utilização do protected para alteração de valores entre classes
        public double Saldo { get; protected set;}
        //Criação do construtor padrão e construtor com parâmetros
        public conta () {}
        public conta (int numero, string titular, double saldo){
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        //Método de Saque
        public void Saque(double saldoTotal){
            Saldo -= saldoTotal;
          }
        //Método de Deposito
        public void Deposito(double saldoTotal){
            Saldo += saldoTotal;
        }
    }
}
