using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo escolha;

            Console.Write("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titularConta = Console.ReadLine();

            do
            {
                Console.Write("Haverá depósito inicial [S/N]? ");
                escolha = Console.ReadKey();
                Console.WriteLine();

            } while ((escolha.Key != ConsoleKey.S) && (escolha.Key != ConsoleKey.N));


            ContaBancaria conta;

            if (escolha.Key == ConsoleKey.S)
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());

                conta = new ContaBancaria(numeroConta, titularConta, depositoInicial);
            }
            else
                conta = new ContaBancaria(numeroConta, titularConta);

            GetDadosBanco(conta);

            Console.Write("\nEntre um valor para depósito: ");
            conta.Depositar(double.Parse(Console.ReadLine()));

            GetDadosBanco(conta);

            Console.Write("Entre um valor para saque: ");
            conta.Sacar(double.Parse(Console.ReadLine()));

            GetDadosBanco(conta);

            Console.ReadKey();
        }

        static void GetDadosBanco(ContaBancaria conta)
        {
            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(conta.ToString());
        }
    }
}
