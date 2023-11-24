class Task
{
    static void Main()

    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
        Task7();
        Task8();
        Task9();
        Task10();
    }

    static void Task1()
    {
        int a = 3333;

        int b = 7;

        int c = 8;

        string result = $"{b}{a}{c}";

        Console.WriteLine(result);

    }

    static void Task2()
    {
        int a = 333;
        string cavab = $"{a}{a}";
        Console.WriteLine(cavab);
    }

    static void Task3()
    {
        int a = 10000;
        int b = (int)(a * 0.18);
        int cavab = (int)(b * 0.03);
        Console.WriteLine(cavab);
    }

    static void Task4()
    {
        int a = 111;
        int b = a * 10 + 7;
        int cavab = (int)(b * 0.07);
        Console.WriteLine(cavab);
    }

    static void Task5()
    {
        int a = 1111;
        int b = (4 * 10000 + a) * 100 + 44;
        int cavab = (int)(b * 0.44);
        Console.WriteLine(cavab);
    }

    static void Task6()
    {
        int a = 1000;
        int b = (int)(a * 0.2);
        int c = (int)(b * 0.1);
        int cavab = c * c;
        Console.WriteLine(cavab);
    }

    static void Task7()
    {
        int a = 11111;
        int b = 22222;
        int c = a + b;

        int d = (5 * 100000 + c) * 10 + 5;
        int cavab = (int)(d * 0.05);

        Console.WriteLine(cavab);
    }

    static void Task8()
    {
        int a = 1000;
        int b = 1000000;

        int c = (int)(a * 0.04);
        int d = (int)(b * 0.09);
        int e = c + d;

        int cavab = (int)(e * 0.1);
        Console.WriteLine(cavab);
    }

    static void Task9()
    {
        int a = 100000;
        int b = 200000;
        int c = 300000;

        int d = (int)(a * 0.1);
        int e = (int)(b * 0.1);
        int f = (int)(c * 0.1);

        int toplam = d + e + f;
        int cavab = (int)(toplam * 0.1);
        Console.WriteLine(cavab);
    }

    static void Task10()
    {
        int a = 1000;
        int b = 2000;
        int c = 3000;

        int cc = (int)(c * 0.07);

        int d = (int)(a * 0.01);
        int e = (int)(b * 0.02);
        int f = (int)(c * 0.03);


        int g = d - e - f;
        int cavab = g + cc;
        Console.WriteLine(cavab);
    }
}



