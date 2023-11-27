using Spectre.Console;

public static class MenuFunctions
{

    public static void HoursToMinutes()
    {
        int hours = AnsiConsole.Ask<int>("How many [purple]Hours[/] ?");
        int minutes = hours * 60;
        AnsiConsole.WriteLine($"{hours} hours is {minutes} minutes");
    }
}