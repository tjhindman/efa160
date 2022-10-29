
public class RealConsole: IConsole
{
    public void ChangeColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }

    public void Clear()
    {
        Console.Clear();
    }

    public ConsoleKeyInfo ReadKey()
    {
        return Console.ReadKey();
    }

    public string ReadLine()
    {
        return Console.ReadLine();
    }

    public void ResetConsoleColor()
    {
        Console.ResetColor();
    }

    public void Write(string s)
    {
        Console.Write(s);
    }

    public void WriteLine(string s)
    {
        Console.WriteLine(s);
    }

    public void WriteLine(object o)
    {
        Console.WriteLine(o);
    }
}
