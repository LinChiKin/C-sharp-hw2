using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_hw2
{
    internal class Program
    {
        public static IEnumerable<string> list;
        static void Main(string[] args)
        {
            bool loop = true;
            while(loop)
            {
                try
                {
                    Console.Write("輸入 ");
                    string input = Console.ReadLine();
                    string[] arr = input.Split(',');
                    list = (from x in arr orderby x descending select x);
                    break;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }
            }

            bool bool1 = false;
            Console.Write("結果 ");
            foreach (string i in list)
            {
                if (bool1)
                {
                    Console.Write(",");
                }
                else
                {
                    bool1 = true;
                }
                Console.Write(i);
            }
            Console.ReadLine();

        }
    }
}
