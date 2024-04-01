using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LR_10
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Введіть дату у форматі YYYY-MM-DD:");
                string inputDate = Console.ReadLine();
                string dayOfWeek = DayOfWeek(inputDate);
                Console.WriteLine(dayOfWeek);
                Console.WriteLine("Натисніть Enter для завершення");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    break;
                }
                Console.Clear();
                    


            }
        }
       
        static string DayOfWeek(string InputText)
        {
            Regex regex = new Regex(@"^[0-9]{4}-[0-9]{1,2}-[0-9]{1,2}$");
            if (regex.IsMatch(InputText) == false)
            {
                return "Невірний формат дати. Введіть дату в форматі YYYY-MM-DD";
            }
            string[] dateParts = InputText.Split('-');
            int year = int.Parse(dateParts[0]);
            int month = int.Parse(dateParts[1]);
            int day = int.Parse(dateParts[2]);

            try
            {
                DateTime FullDate = new DateTime(year, month, day);
                DayOfWeek dayOfWeek = FullDate.DayOfWeek;
                return "День тижня: " + dayOfWeek.ToString();
            }
            catch (Exception)
            {
                return "Невірна дата";
            }

        }
     
    }
}
