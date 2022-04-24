using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaFernanda = new ContaCorrente();

            contaDaFernanda.titular = "Fernanda";
            contaDaFernanda.agencia = 863;
            contaDaFernanda.numero = 863452;
            contaDaFernanda.saldo = 100;

            Console.WriteLine(contaDaFernanda.titular);
            Console.WriteLine("Agência: " + contaDaFernanda.agencia);
            Console.WriteLine("Número: " + contaDaFernanda.numero);
            Console.WriteLine("Saldo: " + contaDaFernanda.saldo);

            contaDaFernanda.saldo += 200;
            Console.WriteLine("Saldo: " + contaDaFernanda.saldo);

            Console.ReadLine();
        }
    }
}
