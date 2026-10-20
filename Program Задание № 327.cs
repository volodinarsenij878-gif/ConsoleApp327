using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program167
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Клавиша (W, A, S, D): ");
            string  key = Console.ReadLine()?.Trim().ToUpper();
            if (string.IsNullOrEmpty(key) || key.Length != 1) { Console.WriteLine("Ошибка."); return; }

            char k = key[0];
            string dir;

            switch (k)
            {
                case 'W': dir = "вперед"; break;
                case 'A': dir = "влево"; break;
                case 'S': dir = "назад"; break;
                case 'D': dir = "вправо"; break;
                default:
                    Console.WriteLine("Неверная клавиша.");
                    return;
            }

            Console.WriteLine(dir);
        }
    }
}