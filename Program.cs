using Spectre.Console;

public static class Start
{
    public static void whaddyaWannaDo()
    {
        var answer = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("whats your [red]favorite thing[/]?")
                .AddChoices(new[]{
                    "convert minutes to hours","total wage for the week","Exit"
                
                }));
            
        switch(answer)
        {
            case "convert minutes to hours":
                MenuFunctions.HoursToMinutes(); // calculates total hours a task would take 
                break;
            case "total wage for the week":
                MenuFunctions.HowMuchAreYouGettingPaidThisWeek();
                break;
            case "exit":
                Environment.Exit(1);
                break;
        }
    }
}
public static class timeCalculator
{
    public static void Main()
    {
       
        AnsiConsole.Clear();
        Start.whaddyaWannaDo();
        
    }
}
