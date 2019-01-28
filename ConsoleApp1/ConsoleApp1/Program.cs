using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t = 0; t < T; t++)
            {
                string line = Console.ReadLine();
                string[] space = line.Split(' ');
                int a = int.Parse(space[0]);
                int b = int.Parse(space[1]);
                int Ab = int.Parse(space[2]);
                int An = a - Ab;
                int Ba = b - An;
                Console.WriteLine(Ba);
            }
        }
    }
}
