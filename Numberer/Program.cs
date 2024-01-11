namespace Numberer;

class Program // hei på deg
{
    static void Main(String[] args)
    {
        Console.WriteLine("numberer");
        foreach (string s in args)
        {
            Console.WriteLine(s);
        }
    }
}