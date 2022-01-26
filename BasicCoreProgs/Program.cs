using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your user name");
            string user = Convert.ToString(Console.ReadLine());
            int k = user.Length;
            if (k == 3 || k > 3)
            {
                Console.WriteLine("Hello " + user + ". How are you today");
                Console.ReadLine();
                Console.WriteLine("please press any key to exit");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Please enter 3 character minimum");
                Console.ReadLine();
            }
            return;

        }
    }
}
