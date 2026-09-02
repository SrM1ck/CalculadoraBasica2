using System;

class URI
{

    static void Main(string[] args)
    {
        double x, y;
        char c;

        Console.WriteLine("Entre com o calculo básico na mesma linha:");

        string[] ch = Console.ReadLine().Split(' ');
        x = double.Parse(ch[0]);
        c = char.Parse(ch[1]);
        y = double.Parse(ch[2]);

        if (c == ('+'))
        {
            Console.WriteLine($"={x+y}");
        }
        else if (c == ('-'))
        {
            Console.WriteLine($"={x-y}");
        }
        else if (c == ('*'))
        {
            Console.WriteLine($"={x * y}");
        }
        else if (c == ('/'))
        {
            Console.WriteLine($"={x / y}");
        }
        Console.ReadLine();
    }

}