using CalculatorApp;

//var calculator = new Calculator(ConsoleLog.PrintInfo);
var file = new FileLog()
{
    Path = "calc.log"
};
//var calculator = new Calculator(file.WriteToFile);

var log = new Action<string>(file.WriteToFile);
log += ConsoleLog.PrintInfo;

var calculator = new Calculator(log);
calculator.Add(5, 10);
calculator.Sub(5, 10);
calculator.Mul(5, 10);
calculator.Div(5, 10);