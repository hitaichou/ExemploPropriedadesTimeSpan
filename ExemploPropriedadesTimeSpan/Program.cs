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
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            //-------------------------------------------------
            //-------------------------------------------------
            //-------------------------------------------------
            Console.WriteLine("Propriedades TimeSpan:");
            TimeSpan t2 = TimeSpan.MaxValue;
            TimeSpan t3 = TimeSpan.MinValue;
            TimeSpan t4 = TimeSpan.Zero;
            TimeSpan t5 = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine("Days: " + t5.Days);
            Console.WriteLine("Hours: " + t5.Hours);
            Console.WriteLine("Minutes: " + t5.Minutes);
            Console.WriteLine("Milliseconds: " + t5.Milliseconds);
            Console.WriteLine("Seconds: " + t5.Seconds);
            Console.WriteLine("Ticks: " + t5.Ticks);

            Console.WriteLine("TotalDays: " + t5.TotalDays);
            Console.WriteLine("TotalHours: " + t5.TotalHours);
            Console.WriteLine("TotalMinutes: " + t5.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t5.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t5.TotalMilliseconds);
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            //-------------------------------------------------
            //-------------------------------------------------
            //-------------------------------------------------
            Console.WriteLine("Operações TimeSpan:");
            TimeSpan tt1 = new TimeSpan(1, 30, 10);
            TimeSpan tt2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = tt1.Add(tt2);
            TimeSpan dif = tt1.Subtract(tt2);
            TimeSpan mult = tt2.Multiply(2.0);
            TimeSpan div = tt2.Divide(2.0);

            Console.WriteLine(tt1);
            Console.WriteLine(tt2);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Dif: " + dif);
            Console.WriteLine("Mult: " + mult);
            Console.WriteLine("Div: " + div);

            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            //-------------------------------------------------
            //-------------------------------------------------
            //-------------------------------------------------
            Console.WriteLine("DateTimeKind:");

            //Boa prática: Armazenar em BD ou XML a data no padrão UTC
            //Quando for mostrar para o usuário, converter para o padrão local

            DateTime dt1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime dt2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime dt3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("Dt1: " + dt1);
            Console.WriteLine("Dt1 Kind: " + dt1.Kind);
            Console.WriteLine("Dt1 to Local "+ dt1.ToLocalTime());
            Console.WriteLine("Dt1 to UTC " + dt1.ToUniversalTime());

            Console.WriteLine();

            Console.WriteLine("Dt2: " + dt2);
            Console.WriteLine("Dt2 Kind: " + dt2.Kind);
            Console.WriteLine("Dt2 to Local " + dt2.ToLocalTime());
            Console.WriteLine("Dt2 to UTC " + dt2.ToUniversalTime());

            Console.WriteLine();

            Console.WriteLine("Dt3: " + dt3);
            Console.WriteLine("Dt3 Kind: " + dt3.Kind);
            Console.WriteLine("Dt3 to Local " + dt3.ToLocalTime());
            Console.WriteLine("Dt3 to UTC " + dt3.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("-------------------------------");
            //-------------------------------------------------
            //-------------------------------------------------
            //-------------------------------------------------
            Console.WriteLine("Padrão ISO 8601:");

            DateTime dd1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime dd2 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine(dd1);
            Console.WriteLine(dd2);

            Console.WriteLine();

            Console.WriteLine("dd1: " + dd1);
            Console.WriteLine("dd1 Kind: " + dd1.Kind);
            Console.WriteLine("dd1 to Local " + dd1.ToLocalTime());
            Console.WriteLine("dd1 to UTC " + dd1.ToUniversalTime());

            Console.WriteLine();

            Console.WriteLine("dd2: " + dd2);
            Console.WriteLine("dd2 Kind: " + dd2.Kind);
            Console.WriteLine("dd2 to Local " + dd2.ToLocalTime());
            Console.WriteLine("dd2 to UTC " + dd2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(dd2.ToString("yyyy-MM-ddTHH:mm:ssZ"));//embora funcione, é recomendado converter primeiro para UTC para depois usar o toString
            Console.WriteLine(dd2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}
