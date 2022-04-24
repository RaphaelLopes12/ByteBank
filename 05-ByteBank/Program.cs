using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente fernanda = new Cliente();

            fernanda.nome = "Fernanda";
            fernanda.profissao = "Desenvolvedora C#";
            fernanda.cpf = "435.786.942-20";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = fernanda;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            conta.titular.nome = "Fernanda Silva";

            Console.WriteLine(fernanda.nome);
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}
