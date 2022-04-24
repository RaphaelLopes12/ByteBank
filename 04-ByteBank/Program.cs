using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoRaphael = new ContaCorrente();
            contaDoRaphael.titular = "Raphael";

            Console.WriteLine(contaDoRaphael.saldo);

            bool resultadoSaque = contaDoRaphael.Sacar(500); 
            
            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaDoRaphael.saldo);

            contaDoRaphael.Depositar(500);
            Console.WriteLine(contaDoRaphael.saldo);

            Console.ReadLine();
        }
    }
}
