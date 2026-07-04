namespace helloapp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("hello everyone");
        greetBlack();
        greetWhite();

    }

    static void greetWhite()
    {
        Console.WriteLine("hello white");
    }

    static void greetBlack()
    {
        Console.WriteLine("hello black");
    }
}