using System;
using static System.Console;
using System.Collections.Generic;
using static System.Convert;
using Studentalib;

namespace ZD8
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введи дату: ");
            WriteLine("День: ");
            int day = ToInt32(ReadLine());
            WriteLine("Месяц: ");
            int month = ToInt32(ReadLine());
            WriteLine("Год: ");
            int year = ToInt32(ReadLine());
            Class1 a = new Class1();
            int n = 1;
            while (n > 0)
            {
                WriteLine("1 - Добавить студента.\n2 - Изменить данные о студенте.\n3 - Удалить студента.\n4 - Вывод всех студентов.");
                int m = ToInt32(ReadLine());
                if (m == 1)
                {
                    a.show();
                }
                else if (m == 2)
                {
                    a.initials("ID");
                }
                else if (m == 3)
                {
                    a.Vozrast(m, day, month, year);
                }
                else if (m == 4)
                {

                    a.Vozrast(m, day, month, year);
                }
                WriteLine("Введи действие:");

                if (n == 2)
                {
                    WriteLine("Введи ID и измененные данные: ");

                    WriteLine("ID: "); string ID = ReadLine();

                    WriteLine("ФИО: "); string FIO = ReadLine();

                    WriteLine("Группа: "); string GROUP = ReadLine();

                    WriteLine("Дата: "); string DATA = ReadLine();

                    a.add(ID, FIO, GROUP, DATA);

                    WriteLine("Введи действие: ");
                }
                else if (n == 4)
                {
                    WriteLine("Введи ID и измененные данные: ");

                    WriteLine("ID: "); string ID = ReadLine();

                    WriteLine("ФИО: "); string FIO = ReadLine();

                    WriteLine("Группа: "); string GROUP = ReadLine();

                    WriteLine("Дата: "); string DATA = ReadLine();

                    a.change(ID, FIO, GROUP, DATA);

                    WriteLine("Введи действие: ");
                }
                else if (n == 3)
                {
                    WriteLine("Введи ID: ");

                    string ID = ReadLine();

                    a.remov(ID);

                    WriteLine("Введи действие: ");

                }
                else if (n == 5)
                {
                    {
                        WriteLine("1 - поиск по ID.\n2 - поиск по фамилии\n");
                        int k = ToInt32(ReadLine());
                        if (m == 1)
                        {
                            WriteLine("Введи ID: ");
                            string ID = ReadLine();
                            a.initials(ID);
                        }
                        else if (m == 2)
                        {
                            WriteLine("Введи фамилию: ");
                            string famil = ReadLine();
                            a.surname(famil);
                            WriteLine("Введи действие: ");

                        }
                        else if (n == 6)
                        {
                            Environment.Exit(0);
                        }
                    }




                }
            }
        }
    }   
}
