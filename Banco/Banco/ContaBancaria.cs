using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaBancaria
    {
        private const float TAXA_SAQUE = 5.00F;

        private string NomeTitular { get; set; }
        private int NumeroConta { get;}
        private double Saldo { get; set;}        

        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double depositoInicial) : this(numeroConta, nomeTitular)
        {
            Depositar(depositoInicial);
        }

        public void AlterarNomeTitular(string novoNome)
        {
            NomeTitular = novoNome;
        }

        public void Depositar(double valorDeposito)
        {
            Saldo += valorDeposito;
        }

        public void Sacar(double valorSaque)
        {
            Saldo -= valorSaque + TAXA_SAQUE;
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + ", "
                + "Titular " + NomeTitular + ", "
                + "Saldo " + Saldo.ToString("C") + "\n";
        }
    }
}
