
public interface IConsole
{
    string ReadLine();
    ConsoleKeyInfo ReadKey();
    void Clear();
    void Write(string s);
    void WriteLine(string s);
    void ChangeColor(ConsoleColor color);
    void ResetConsoleColor();

}
