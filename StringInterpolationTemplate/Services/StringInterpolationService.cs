using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services { 

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
        
            throw new NotImplementedException();
    }

    //2.2019.01.22
    public string Number02()
    {
            var date=_date.Now.ToString($" {today:yyyy}.{today:MM}.{today:dd}");  
            var answer = $"{date}";
            Console.WriteLine(answer);

            return answer;

                throw new NotImplementedException();
    }

    public string Number03()
    {
            var date=_date.Now.ToString($"Day {today:dd} of {today:MMMM}, {today:yyyy}");
            var answer = $"{date}";
            Console.WriteLine(answer);

            return answer;

        throw new NotImplementedException();
    }

    public string Number04()
    {

           var date=_date.Now.ToString($"Year: {today:yyyy}, Month: {today:MM}, Day: {today:dd}");
            var answer = $"{date}";
            Console.WriteLine(answer);

            return answer;


        throw new NotImplementedException();
    }

    public string Number05()
    {
            var date=_date.Now.ToString($"{today:dddd}");

            var answer = $"{date}";
            Console.WriteLine(answer);

            return answer;

        throw new NotImplementedException();
    }

    public string Number06()

    {
            string currenthour = ($"{today:hh}");
            string currentminute = ($"{today:mm}");
            string currentdow = ($"{today:dddd}");

            var date = _date.Now.ToString($"6. {currenthour,8}:{currentminute,8} {today:tt} {currentdow,5}");
            var answer = $"{date}";
            Console.WriteLine(answer);

            return answer;
        throw new NotImplementedException();
    }

    public string Number07()
    {

            var date = _date.Now.ToString($"7. h:{today:hh},m:{today:mm},s:{today:ss}");
            var answer = $"{date}";
            Console.WriteLine(answer);

            return answer;

        throw new NotImplementedException();
    }

    public string Number08()
    {
            var date = _date.Now.ToString($"8. {today:yyyy}.{today:MM}.{today:dd}.{today:hh}.{today:mm}.{today:ss}");
             var answer = $"{date}";
            Console.WriteLine(answer);

            return answer;

        throw new NotImplementedException();
    }

    public string Number09()
    {
        throw new NotImplementedException();
    }

    public string Number10()
    {
        throw new NotImplementedException();
    }

    public string Number11()
    {
        throw new NotImplementedException();
    }

   
}
}