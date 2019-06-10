using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика11
{
    public class Program
    {

        static public char[] CorrectEntry()
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
            return a.ToCharArray();
        }
        static public int ReadIntNumber(string stringForUser, int left, int right)
        {
            bool okInput = false;
            int number = -100;
            do
            {
                Console.WriteLine(stringForUser);
                try
                {
                    string buf = Console.ReadLine();
                    number = Convert.ToInt32(buf);
                    if (number >= left && number < right) okInput = true;
                    else
                    {
                        Console.WriteLine("Неверно введено число!");
                        okInput = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Неверно введено число!");
                    okInput = false;
                }
            } while (!okInput);
            return number;
        }
        static public void RunMenu()
        {
            char[] a = null;
            int check = 0;
            do
            {
                Console.WriteLine(@"1. Ввести последовательность
2. Зашифровать данную последовательность
3. Расшифровать последовательность
4. Выход");
                check = ReadIntNumber("", 1, 5);
                switch (check)
                {
                    case 1:
                        {
                            a = CorrectEntry();
                        }
                        break;
                    case 2:
                        {
                            if (a != null)
                            {
                                a = Coding(a);
                                Console.WriteLine(a);
                            }
                            else Console.WriteLine("Вы не ввели последовательность");
                        }
                        break;
                    case 3:
                        {
                            if (a != null)
                            {
                                a = Transcription(a);
                                Console.WriteLine(a);
                            }
                            else Console.WriteLine("Вы не ввели последовательность");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Нажмите любую клавишу, чтобы выйти :)");
                        break;
                    default:
                        Console.WriteLine("Ошибка!");
                        break;
                }
            } while (check < 4);
        }
        static public char[] Coding(char[] a)
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

        static public char[] Transcription(char[] a)
        {
            char[] b = new char[a.Length];
            b[0] = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (b[0] == '0' || b[0] == '1')
                {
                    if (a[i] == '0')
                    {
                        if (b[i - 1] == '0') b[i] = '1';
                        else b[i] = '0';
                    }
                    else
                    {
                        if (b[i - 1] == '1') b[i] = '1';
                        else b[i] = '0';
                    }
                }
                else
                {
                    if (a[i] == '.')
                    {
                        if (b[i - 1] == '.') b[i] = '-';
                        else b[i] = '.';
                    }
                    else
                    {
                        if (b[i - 1] == '-') b[i] = '-';
                        else b[i] = '.';
                    }
                }
            }
            return b;
        }

        static void Main(string[] args)
        {
            RunMenu();
        }
    }
}
