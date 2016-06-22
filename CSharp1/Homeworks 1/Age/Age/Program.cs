using System;

class PrintDateTime
{
    static void Main(string[] args)
    {
        int yourAge;
        DateTime yourBirthay = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", null);
        DateTime now = DateTime.Now;
        if (now.Date < yourBirthay.Date)
            yourAge = 0;
        else {
            yourAge = now.Year - yourBirthay.Year;
            if (now.Month < yourBirthay.Month)
                yourAge--;
            else if (now.Month == yourBirthay.Month)
                if (now.Day < yourBirthay.Day)
                    yourAge--;
        }
        Console.WriteLine(yourAge);
        Console.WriteLine(yourAge + 10);
    }
}

