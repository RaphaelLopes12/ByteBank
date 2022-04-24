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

            ContaCorrente contaDaFernanda = new ContaCorrente();
            contaDaFernanda.titular = "Fernanda";

            Console.WriteLine("Saldo do Raphael: " + contaDoRaphael.saldo);
            Console.WriteLine("Saldo da Fernanda: " + contaDaFernanda.saldo);

            bool resultadoTransferencia = contaDoRaphael.Transferir(200, contaDaFernanda);

            Console.WriteLine("Saldo do Raphael: " + contaDoRaphael.saldo);
            Console.WriteLine("Saldo da Fernanda: " + contaDaFernanda.saldo);

            Console.WriteLine("Resultado tranferência: " + resultadoTransferencia);

            contaDaFernanda.Transferir(100, contaDoRaphael);

            Console.WriteLine("Saldo do Raphael: " + contaDoRaphael.saldo);
            Console.WriteLine("Saldo da Fernanda: " + contaDaFernanda.saldo);

            Console.ReadLine();
        }
    }
}
