namespace CalculatorApp;

public static class ConsoleLog
{
    private static void Print(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public static void PrintInfo(string message)
    {
        Print(message, ConsoleColor.Green);
    }
}