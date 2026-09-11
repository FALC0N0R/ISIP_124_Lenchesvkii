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
            bool rabotaem = true;

            while (rabotaem)
            {
                Console.WriteLine();
                Console.WriteLine("1 - Показать траты");
                Console.WriteLine("2 - Статистика");
                Console.WriteLine("3 - Сортировка");
                Console.WriteLine("4 - Конвертация");
                Console.WriteLine("5 - Поиск");
                Console.WriteLine("0 - Выход");
                Console.Write("Выбери: ");

                int punkt = Convert.ToInt32(Console.ReadLine());

                switch (punkt)
                {
                    case 1:
                        Console.WriteLine("Все траты:");
                        for (int k = 0; k < kolvo; k++)
                        {
                            Console.WriteLine((k + 1) + ") " + tovary[k] + " - " + ceny[k] + " руб.");
                        }
                        break;
                    case 2:
                        double summa = 0;
                        double max = ceny[0];
                        double min = ceny[0];

                        for (int k = 0; k < kolvo; k++)
                        {
                            summa = summa + ceny[k];

                            if (ceny[k] > max) max = ceny[k];
                            if (ceny[k] < min) min = ceny[k];
                        }

                        double sred = summa / kolvo;

                        Console.WriteLine("Сумма: " + summa);
                        Console.WriteLine("Средн: " + sred);
                        Console.WriteLine("Макс: " + max);
                        Console.WriteLine("Мин: " + min);
                        break;

                    case 3:
                        for (int a = 0; a < kolvo - 1; a++)
                        {
                            for (int b = 0; b < kolvo - 1 - a; b++)
                            {
                                if (ceny[b] > ceny[b + 1])
                                {
                                    double buf = ceny[b];
                                    ceny[b] = ceny[b + 1];
                                    ceny[b + 1] = buf;

                                    string buf2 = tovary[b];
                                    tovary[b] = tovary[b + 1];
                                    tovary[b + 1] = buf2;
                                }
                            }
                        }

                        Console.WriteLine("Отсортировано!");
                        break;
                    
                    case 0:
                        Console.WriteLine("Пока");
                        rabotaem = false;
                        break;

                    default:
                        Console.WriteLine("Нет такого пункта");
                        break;
                }
            }
        }
    }
}   