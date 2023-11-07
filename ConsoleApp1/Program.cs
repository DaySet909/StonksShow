using System;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { 
            //int i = 0;
            //while (i < 1)
            //{ 
            DateTime qTime = new DateTime(2023, 3, 15);
            //qTime = qTime.AddDays(i);
            Time(qTime);
            //    i++;
            //}
            string path = @"C:\Users\DenKy\Desktop\kurosava.txt";

            using (StreamWriter writer = new StreamWriter(path, true))      //записыается новое значение и к нему прикрепляется дата
            {
                Console.WriteLine("Введите новое значение");
                string q = Console.ReadLine();
                writer.WriteLineAsync(q);
            }

            //using (StreamReader reader = new StreamReader(path))       //считываться должны старые данные и дата к ним
            //{
            //    string? line;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}

            void Time(DateTime dateTime )
                {
                DateTime y = dateTime;
                DateTime x = DateTime.Now;
                var z = (y - x).Duration();

                int oldCoin = 0;
                int newCoin = 0;
                oldCoin -= newCoin;
                
                Console.WriteLine($"Значение изменилось на {oldCoin} за {z.Days} дней ");
                }
            
        }
    }
}
//DateTime oldTime = dateTime;
                //DateTime newTime = DateTime.Now;

                //if (oldTime > newTime) throw new ArgumentException("Начальная дата не может быть больше конечной");

                //var years = newTime.Year - oldTime.Year;

                //var month = newTime.Month - oldTime.Month
                // + (newTime.Day >= oldTime.Day - 1 ? 0 : -1);
                //    //+ ((oldTime.Day == 1 && DateTime.DaysInMonth(newTime.Year, newTime.Month) == newTime.Day) ? 1 : 0);

                //if (month < 0) month = 12 + month;

                //var days = (newTime.Day + DateTime.DaysInMonth(oldTime.Year, oldTime.Month) - oldTime.Day);

                //if (newTime.Day > oldTime.Day) days = newTime.Day - oldTime.Day; // для чисел когда старое больше нового

                ////if (days == 31) month -= 1;