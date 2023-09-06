namespace CalculatorApp;

//public delegate void Message(string message);

public class Calculator
{
    private Action<string> _log;

    public Calculator(Action<string> log)
    {
        _log = log;
    }

    public double Add(double x, double y)
    {
        var result = x + y;
        _log($"{x} + {y} = {result}");
        return result;
    }
    public double Sub(double x, double y) 
    {
        var result = x - y;
        _log($"{x} - {y} = {result}");
        return result;
    }
    public double Mul(double x, double y)
    {
        var result = x * y;
        _log($"{x} * {y} = {result}");
        return result;
    }
    public double Div(double x, double y)
    {
        var result = x / y;
        _log($"{x} / {y} = {result}");
        return result;
    }
}