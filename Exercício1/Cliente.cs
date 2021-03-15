using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício1
{
    public class Cliente
    {
        public int Codigo { get; set; } // atributos

        public string CpfCnpj { get; set; } // "string" e não "int" para evitar a eliminação do zero à esquerda

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public bool ConstaSPC { get; set; }

        public ContaCorrente ContaCorrente { get; set; } // fazer a interligação entre o cliente e a conta dele

        public ContaPoupanca ContaPoupanca { get; set; }

        public Cliente() // construtor > quando o objeto nasce, já leva consigo mais informações
        {
            ContaCorrente = new ContaCorrente(); // cria o espaço na memória para a conta, criou o objeto "contapoupanca", que é acessado através do cliente
            ContaCorrente.Agencia = 1;
            ContaCorrente.Numero = 123456;

            ContaPoupanca = new ContaPoupanca();
            ContaPoupanca.Agencia = 1;
            ContaPoupanca.Numero = 987654;

        }

    }
}
