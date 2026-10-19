using System;

class Program()
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("hello everyone");

        greetBlack();
        greetWhite();

        return 0;
    }

    public static void greetWhite()
    {
        System.Console.WriteLine("hello white");
    }

    public static void greetBlack()
    {
        System.Console.WriteLine("hello black");
    }
}