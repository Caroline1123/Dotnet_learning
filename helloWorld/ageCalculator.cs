// See https://aka.ms/new-console-template for more information

DateTime birthday = new DateTime(1991,08,30);
DateTime today = DateTime.Now;
TimeSpan difference = today.Subtract(birthday);

Console.WriteLine($"You are {Math.Floor(difference.TotalDays/365)} years old.");