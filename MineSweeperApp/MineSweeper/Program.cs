﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] result = Miner.SearchMines(new string[5] { "*..", ".*.", "..**.", "..*", ".*" });
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
            Console.Read();
        }
    }
}
