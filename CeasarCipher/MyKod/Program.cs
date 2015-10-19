using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ceasar.Tests;
namespace MyKod
{
    class Program
    {
        private static void Main(string[] args)
        {
            CeasarCipher start = new CeasarCipher(1);
            start.Encrypt("home work 2");
            Console.WriteLine(start.Encrypt("home work 2"));
            string nemp = start.Encrypt("home work 2");
            start.Decrypt(nemp);
            Console.WriteLine(start.Decrypt(nemp));
        }
    }
}
