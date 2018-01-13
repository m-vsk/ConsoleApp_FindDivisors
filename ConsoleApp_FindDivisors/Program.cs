using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_FindDivisors
{
    public class Kata
    {
        public static int[] Divisors(int n)
        {
            var div = from a in Enumerable.Range(2, n / 2) where n % a == 0 select a;
            if (div.Count() > 0)
                return div.ToArray();
            else return new int[] {};
        }
    }

/*
            Assert.AreEqual(new int[] { 3, 5 }, Kata.Divisors(15));
            Assert.AreEqual(new int[] { 2, 4, 8 }, Kata.Divisors(16));
            Assert.AreEqual(new int[] { 11, 23 }, Kata.Divisors(253));
            Assert.AreEqual(new int[] { 2, 3, 4, 6, 8, 12 }, Kata.Divisors(24));
*/

    class Program
    {
        static void Main(string[] args)
        {

            foreach (var i in Kata.Divisors(13))
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();

        }
    }
}
