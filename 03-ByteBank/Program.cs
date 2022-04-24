using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaFernanda = new ContaCorrente();
            contaDaFernanda.titular = "Fernanda";
            contaDaFernanda.agencia = 863;
            contaDaFernanda.numero = 863452;

            ContaCorrente contaDaFernandaSilva = new ContaCorrente();
            contaDaFernandaSilva.titular = "Fernanda";
            contaDaFernandaSilva.agencia = 863;
            contaDaFernandaSilva.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaDaFernanda == contaDaFernandaSilva));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));

            contaDaFernanda = contaDaFernandaSilva;
            Console.WriteLine(contaDaFernanda == contaDaFernandaSilva);

            contaDaFernanda.saldo = 300;
            Console.WriteLine(contaDaFernanda.saldo);
            Console.WriteLine(contaDaFernandaSilva.saldo);

            if(contaDaFernanda.saldo >= 100)
            {
                contaDaFernanda.saldo -= 100;
            }
            

            Console.ReadLine();
        }
    }
}
