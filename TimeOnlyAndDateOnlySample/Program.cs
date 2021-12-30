// See https://aka.ms/new-console-template for more information

using System.Globalization;


// Convert to currentDate
var currentDate = DateOnly.FromDateTime(DateTime.Now);

//TryParse and Parse
if (DateOnly.TryParse("28/09/1984", new CultureInfo("en-US"), DateTimeStyles.None, out var result))
{
    Console.WriteLine(result);
}

// use parse exact
DateOnly d1 = DateOnly.ParseExact("31 Dec 1980", "dd MMM yyyy", CultureInfo.InvariantCulture);  // Custom format
Console.WriteLine(d1.ToString("o", CultureInfo.InvariantCulture)); // "1980-12-31"  (ISO 8601 format)

// work with PersianCalendar
var persianCalendar = new PersianCalendar();
DateOnly d2 = new DateOnly(1400, 9, 6, persianCalendar);
Console.WriteLine(d2.ToString("d MMMM yyyy", CultureInfo.InvariantCulture));

// methods
var date = new DateOnly(2020, 04, 20);

var newDate = date.AddDays(1).AddMonths(1).AddYears(1);

// New in .Net 6

// overloads

//public TimeOnly(int hour, int minute);
//public TimeOnly(int hour, int minute, int second);
//public TimeOnly(int hour, int minute, int second, int millisecond);

var dd = new DateOnly(2021, 2, 1);

var startTime = new TimeOnly(10, 30);
var endTime = new TimeOnly(13, 00, 00);

var diff = endTime - startTime;
Console.WriteLine($"Hours: {diff.TotalHours}");

// ToTimeSpan
TimeSpan ts = endTime.ToTimeSpan();


 // Convert to DateTime

var currentTime = TimeOnly.FromDateTime(DateTime.Now);

DateTime dt = date.ToDateTime(new TimeOnly(0, 0));
Console.WriteLine(dt);

// Comparison
var isBetween = currentTime.IsBetween(startTime, endTime);
Console.WriteLine($"Current time {(isBetween ? "is" : "is not")} between start and end");

var startTime2 = new TimeOnly(08, 00);
var endTime2 = new TimeOnly(09, 00);

Console.WriteLine($"{startTime2 < endTime2}");

Console.WriteLine("Hello, World!");


