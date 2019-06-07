using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика11
{
    public class Program
    {
        static public char[] Coding(string a)
        {
            char[] b = new char[a.Length];
            b[0] = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == a[i - 1])
                {
                    if (a[0] == '0' || a[0] == '1') b[i] = '1';
                    else b[i] = '-';
                }
                else
                {
                    if (a[0] == '0' || a[0] == '1') b[i] = '0';
                    else b[i] = '.';
                }
            }
            return b;
        }

        static void Main(string[] args)
        {
            string a = null;
            bool ok = false;
            do
            {
                Console.WriteLine("Введите строку, состоящую из 0 и 1 (или '.' и '-')");
                a = Console.ReadLine();
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[0] == '0' || a[0] == '1')
                        if (a[i] == '0' || a[i] == '1') ok = true;
                        else
                        {
                            ok = false;
                            break;
                        }
                    if (a[0] == '.' || a[0] == '-')
                        if (a[i] == '.' || a[i] == '-') ok = true;
                        else
                        {
                            ok = false;
                            break;
                        }
                }
            } while (!ok);

            char[] b = Coding(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
