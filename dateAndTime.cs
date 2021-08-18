using System;

namespace dateTime
{
    class DateAndTime
    {

        public DateAndTime()
        {

            Console.WriteLine("Date And Time ...");
            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = DateTime.Now;
            DateTime todayDate = DateTime.Today;
            DateTime currentDateTimeUTC = DateTime.UtcNow;
            DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
            DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime

            //assigns year, month, day
            DateTime dt2 = new DateTime(2015, 12, 31);

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);
            Console.WriteLine($" Now : {dt1} \n Today :{todayDate} \n  Current DateTime Utc {currentDateTimeUTC}");
            Console.WriteLine($"Max Date Time : {maxDateTimeValue} \n Min Date Time :{minDateTimeValue}");
            Console.WriteLine($" {dt1} \n {dt2} \n {dt3} \n {dt4}");

            var str = "12/13/2020";
            DateTime dt;

            var isValidDate = DateTime.TryParse(str, out dt);

            if (isValidDate)
                Console.WriteLine(dt);
            else
                Console.WriteLine($"{str} is not a valid date string");


        }


    }
}