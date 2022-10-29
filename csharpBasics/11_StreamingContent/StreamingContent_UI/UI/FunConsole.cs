
public class FunConsole : IConsole
{

    public void ChangeColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }

    public void Clear()
    {
        Console.Clear();
        Console.BackgroundColor = RndColor();
    }

    private ConsoleColor RndColor()
    {
        //cpu sleep
        Thread.Sleep(10);
        Random rnd = new Random();
        int colorIndex = rnd.Next(0, 16);
        return (ConsoleColor)colorIndex;
    }

    public ConsoleKeyInfo ReadKey()
    {
        return Console.ReadKey();
    }

    public string ReadLine()
    {
        //get user input
        string input = Console.ReadLine();
        Console.WriteLine("Ummmm...");
        Thread.Sleep(1000);
        Console.WriteLine("Your sure...");
        Thread.Sleep(100);
        Console.WriteLine(".....Ok?");
        return input;
    }

    public void ResetConsoleColor()
    {
        Console.ResetColor();
    }

    public void Write(string s)
    {
        foreach (char letter in s)
        {
            Console.ForegroundColor = RndColor();
            System.Console.WriteLine(letter);
        }
    }

    public void WriteLine(string s)
    {
        Console.ForegroundColor = RndColor();
        bool captalize = false;
        foreach (var letter in s)
        {
            if (captalize == true)
            {
                Console.ForegroundColor = RndColor();
                System.Console.Write(char.ToUpper(letter));
                captalize = false;
            }
            else
            {
                Console.ForegroundColor = RndColor();
                System.Console.Write(char.ToLower(letter));
                captalize = true;
            }
        }

        //cpu sleep
        Thread.Sleep(50);
        System.Console.WriteLine("\n");
    }
}
