﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
                Stock stock = new Stock();
                Bank bank = new Bank("ЮнитБанк", stock);
                Broker broker = new Broker("Иван Иваныч", stock);

                stock.Market();

                broker.StopTrade();

                stock.Market();

            string mess = "Hello me";
            mess += " art";
            mess.Replace("me", "eleks");
            Console.WriteLine(mess);
                Console.Read();
            
        }
    }
}
