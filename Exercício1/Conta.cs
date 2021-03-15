using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício1
{
    public class Conta
    {
        public int Agencia { get; set; } // atributos

        public int Numero { get; set; }

        public string Tipo { get; set; }

        public decimal Saldo { get; set; }

        public string Status { get; set; }

        public string Sacar(decimal valorParaSaque) // método, ação
        {
            if (valorParaSaque > 500)
                return "Valor acima do limite de saque";

            else
            {
                if (valorParaSaque > Saldo)
                    return "Saldo insuficiente";
                else
                {
                    Saldo = Saldo - valorParaSaque;
                    return "Foi sacado R$ " + valorParaSaque + ". Seu novo saldo agora é de R$ " + Saldo;
                }
            }
        }
        public string Depositar(decimal valorParaDeposito) // método, ação
        {
            if (valorParaDeposito <= 0)
                return "Valor para depoósito não pode ser menor ou igual à zero.";

            else
            {
                Saldo += valorParaDeposito; // pode também usar a simbologia "+=", e substituir o "Saldo +"
                return "Foi depositado R$ " + valorParaDeposito + ". Seu novo saldo agora é R$ " + Saldo;
            }


        }
    }
}
