﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(7480, 874150);

            Console.WriteLine(ContaCorrente.TaxaOperacao);

            Console.ReadLine();
        }
    }
}
