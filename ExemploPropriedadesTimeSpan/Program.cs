using System;

namespace ExemploPropriedadesTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {

            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            DateTime d = new DateTime(2020, 2, 24, 8, 00, 30, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);            
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            //-------------------------------------------------
            //-------------------------------------------------
            //-------------------------------------------------
            Console.WriteLine("Formatando...");
            Console.WriteLine();

            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine(d.ToShortDateString());
            Console.WriteLine(d.ToShortTimeString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(d.ToString("yyyy-mm-dd HH:mm:ss"));
            Console.WriteLine(d.ToString("yyyy-mm-dd HH:mm:ss.fff")); //.fff -> adicionando milissegundo
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            //-------------------------------------------------
            //-------------------------------------------------
            //-------------------------------------------------
            Console.WriteLine("Operações DateTime:");
            Console.WriteLine();
            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(3);
            DateTime d4 = DateTime.Now;
            DateTime d5 = d4.AddDays(7);            

            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine();            
            Console.WriteLine("-------------------------------");
            //-------------------------------------------------
            //-------------------------------------------------
            //-------------------------------------------------
            Console.WriteLine("Diferença entre datas:");
            //Calculando diferença de dias
            DateTime d6 = new DateTime(2020, 03, 02);
            DateTime d7 = new DateTime(2020, 03, 23);
            TimeSpan t = d7.Subtract(d6);
            Console.WriteLine(t);
            Console.WriteLine(t.Days); //somente mostra a quantidade de dias.

        }
    }
}
