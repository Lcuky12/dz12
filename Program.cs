using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = 10;
            int gold;
            int totalCrystal;
            Console.WriteLine(" Сколько кристаллов вам нужно? ");
            totalCrystal = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Сколько у вас золота? ");
            gold = Convert.ToInt32(Console.ReadLine());
            int itog = (gold - price * totalCrystal);
            Console.WriteLine("У вас осталось золота " + itog);
            Console.WriteLine("У вас кристаллов " + totalCrystal);
        }
    }
}
