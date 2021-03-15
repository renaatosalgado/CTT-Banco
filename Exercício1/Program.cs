using System;
using System.Collections.Generic;

namespace Exercício1
{
    public class Program
    {
        static void Main(string[] args)

        {

            PessoaFisica cliente = new PessoaFisica(); // o objeto cliente está instanciado, criado (primeiro cliente = classe, segundo cliente = nome dessa classe aqui)
            cliente.Nome = "Jujuba";



            Console.WriteLine("Olá " + cliente.Nome + ("."));
            bool continua = true;

            while (continua)
            {

                Console.WriteLine("Qual conta você quer movimentar? C - corrente ou P - poupança");
                string conta = Console.ReadLine();

                Console.WriteLine("O que você deseja fazer? D - depósito ou S - saque");
                string resposta = Console.ReadLine();
                
                if (resposta.ToLower() == "d")
                {
                    Console.WriteLine("Qual o valor para depósito?");
                    decimal valorParaDeposito = Convert.ToDecimal(Console.ReadLine());
                    string retorno;

                    if (conta.ToLower() == "c")
                    {
                        retorno = cliente.ContaCorrente.Depositar(valorParaDeposito);
                    }
                    else
                    {
                        retorno = cliente.ContaPoupanca.Depositar(valorParaDeposito);
                    }
                    Console.WriteLine(retorno);
                }

                else if (resposta.ToLower() == "s")
                {
                    Console.WriteLine("Qual o valor para saque?");
                    decimal valorParaSaque = Convert.ToDecimal(Console.ReadLine());
                    string retorno;
                    
                    if (conta.ToLower() == "c")
                    {
                        retorno = cliente.ContaCorrente.Sacar(valorParaSaque);
                    }

                    else
                    {
                        retorno = cliente.ContaPoupanca.Sacar(valorParaSaque);
                    }
                    Console.WriteLine(retorno);
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }

                Console.WriteLine("Sair? s/n");
                continua = Console.ReadLine() != "s"; // comparação lógica para sair
            }
        }
    }
}