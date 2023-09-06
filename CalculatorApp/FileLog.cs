namespace CalculatorApp;

public class FileLog
{
    public string Path { get; init; }
    
    public void WriteToFile(string message)
    {
        var file = new StreamWriter(Path, append: true);
        file.WriteLine(message);
        file.Close();
    }
}