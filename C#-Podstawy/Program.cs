//C# podstawy
class Program
{
    static void constants()
    {
        const double pi = 3.14;
        Console.WriteLine($"Liczba PI to = {pi}\n");
    }

    static void variables()
    {
        int zmienna_x;
        zmienna_x = 10;
        Console.WriteLine($"Zmienna x wynosi = {zmienna_x}\n");

        int zmienna_y = 22;
        Console.WriteLine($"Zmienna y wynosi = {zmienna_y}\n");

        int zmienna_z = zmienna_x + zmienna_y;
        Console.WriteLine($"Zmienna z wynosi = {zmienna_z}\n");

        int age = 16;
        Console.WriteLine($"Mój wiek to = {age}\n");

        double height = 1.80;
        Console.WriteLine($"Mój wzrost to = {height}m\n");

        bool online = true; // bool is true or false
        Console.WriteLine($"Czy jesteś online ? {online}\n");

        char symbol = '%';
        Console.WriteLine($"Twój symbol to: {symbol}\n");

        string name = "Piotr";
        string surname = "Łakomiec";
        Console.WriteLine($"Moje imie to: {name} a nazwikso to: {surname}\n");

        string username = symbol + surname;
        Console.WriteLine($"Twój nick to {username}\n");
    }

    static void type_casting()
    {

    }

    static void Main(string[] args)
    {

        constants();

    }

}