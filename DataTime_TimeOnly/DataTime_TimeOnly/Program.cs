using System;
using System.Globalization;

namespace DataTime_TimeOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            //Метод ParseExact
            /*string date = "25112022";
            DateTime dt = DateTime.ParseExact(date, "ddMMyyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dt);*/

            //Метод Parse
            /*string[] strDate = new string[]
            {
                "08/18/2022 07:22:16",
                "08/18/2022",
                "8/2022",
                "8/18",
                "07:22:16",
                "7 PM",
                "2022-08-18T07:22:16.0000000Z",
                "2022-08-18T07:22:16.0000000-07:00",
                "Thu, 18 Aug 2022 07:22:16 GMT",
                "08/18/2022 07:22:16 -5:00"
            };
            foreach (string str in strDate)
            {
                DateTime dt = DateTime.Parse(str, CultureInfo.GetCultureInfo("en-US"));
                Console.WriteLine($"{dt}");
            }*/

            //Метод TryParse и TryParseExact
            string[] strDate = new string[]
            {
                "08/18/2022 07:22:16",
                "08/18/2022",
                "8/2022",
                "8/18",
                "07:22:16",
                "7 PM",
                "2022-08-18T07:22:16.0000000Z",
                "2022-08-18T07:22:16.0000000-07:00",
                "Thu, 18 Aug 2022 07:22:16 GMT",
                "08/18/2022 07:22:16 -5:00"
            };

            foreach (string str in strDate)
            {
                DateTime dt;
                if (DateTime.TryParse(str, out dt))
                {
                    Console.WriteLine($"{dt}");
                }
                else
                    Console.WriteLine("Ошибка парсинга");
            }
        }
    }
}
