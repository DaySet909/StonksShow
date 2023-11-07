using System;

public class Class1
{
    //Time q = new Time(2023, 5, 20);




    oldTime = new DateTime(2023, 5, 23);
    newTime = DateTime.Now;

            if (oldTime > newTime) throw new ArgumentException("Начальная дата не может быть больше конечной");

    var years = newTime.Year - oldTime.Year;

    var month = newTime.Month - oldTime.Month + (newTime.Day >= oldTime.Day - 1 ? 0 : -1) + ((oldTime.Day == 1 && DateTime.DaysInMonth(newTime.Year, newTime.Month) == newTime.Day) ? 1 : 0);
            if (month <= 0) month = 0;

            var days = (newTime.Day + DateTime.DaysInMonth(oldTime.Year, oldTime.Month) - oldTime.Day);// для чисел когда старое больше нового
            if (newTime.Day > oldTime.Day)
                days = newTime.Day - oldTime.Day;

            Console.WriteLine($"Лет{years} месяцев{month} дней{days}");
            return days;



	public Time()
	{
        oldTime = new DateTime(2023, 5, 23);
        newTime = DateTime.Now;

        if (oldTime > newTime) throw new ArgumentException("Начальная дата не может быть больше конечной");

        var years = newTime.Year - oldTime.Year;

        var month = newTime.Month - oldTime.Month + (newTime.Day >= oldTime.Day - 1 ? 0 : -1) + ((oldTime.Day == 1 && DateTime.DaysInMonth(newTime.Year, newTime.Month) == newTime.Day) ? 1 : 0);
        if (month <= 0) month = 0;

        var days = (newTime.Day + DateTime.DaysInMonth(oldTime.Year, oldTime.Month) - oldTime.Day);// для чисел когда старое больше нового
        if (newTime.Day > oldTime.Day)
            days = newTime.Day - oldTime.Day;

        Console.WriteLine($"Лет{years} месяцев{month} дней{days}");
        return days;
    }
}
