using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_even_seperation
{
    internal class Program
    {
        public static void print(string text,IEnumerable<int> list)
        {
            bool bool1 = false;
            Console.Write(text+" : ");
            foreach (var i in list)
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
            Console.WriteLine();
        }
        public static IEnumerable<int> even_list;
        public static IEnumerable<int> odd_list;
        public static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                try
                {
                    Console.Write("輸入 : ");
                    string input=Console.ReadLine();
                    string[] arr=input.Split(',');
                    int[] int_arr = Array.ConvertAll<string, int>(arr, (s) => int.Parse(s));

                    odd_list = (
                        from x in int_arr
                        where (x%2!=0)
                        select x
                        );
                    even_list = (
                        from x in int_arr
                        where (x % 2 == 0)
                        select x
                        );

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            print("奇數", odd_list);
            print("偶數", even_list);

            Console.ReadLine();
        }
    }
}
