using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            Random rnd = new Random();
            
            for (var first = 0; first< words.Length; first++)
            {
                var second = rnd.Next(0, words.Length);
                var old = words[first];
                words[first] = words[second];
                words[second] = old;

            }
            Console.WriteLine(string.Join("\r\n", words));



        }
    }
}
