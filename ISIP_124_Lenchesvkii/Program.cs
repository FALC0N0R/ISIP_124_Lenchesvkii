using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP124_Lenchevskii
{
    internal class Program
    {
        static string[] tovary = new string[40];
        static double[] ceny = new double[40];
        static int kolvo = 0;

        static void Main(string[] args)
        {
            Console.Write("Сколько трат? (2-40): ");
            kolvo = Convert.ToInt32(Console.ReadLine());

            if (kolvo < 2 || kolvo > 40)
            {
                Console.WriteLine("Надо от 2 до 40");
                return;
            }

            int i = 0;
            while (i < kolvo)
            {
                Console.WriteLine("Трата номер " + (i + 1));
                Console.Write("Введи (название; сумма): ");
                string stroka = Console.ReadLine();

                string[] chasti = stroka.Split(';');

                tovary[i] = chasti[0].Trim();
                ceny[i] = Convert.ToDouble(chasti[1].Trim());

                i++;
            }

            Console.WriteLine("Записано!");
        }
    }
}