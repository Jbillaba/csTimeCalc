using Spectre.Console;

public static class MenuFunctions
{
    public static void HoursToMinutes()
    {
        int hours = AnsiConsole.Ask<int>("How many [purple]Hours[/] ?");
        int minutes = hours * 60;
        AnsiConsole.WriteLine($"{hours} hours is {minutes} minutes");
    }

    public static void HowMuchAreYouGettingPaidThisWeek()
    {
        int wagePerHour = AnsiConsole.Ask<int>("How much are you getting paid per [blue]hour[/]");
        int hours = AnsiConsole.Ask<int>("How many [blue]hours[/] did you work ?");
        int takingHome = wagePerHour * hours;
        AnsiConsole.WriteLine($"youre taking home {takingHome} dollars this week (note this is before taxes)");
    }
}