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
        double zmienna_zmiennoprzecinkowa = 3.34;
        int zmienna_całokowita = Convert.ToInt32(zmienna_zmiennoprzecinkowa);

        int zmienna_całokowita_2 = 23;
        double zmienna_zmiennoprzecinkowa_2 = Convert.ToDouble(zmienna_całokowita_2) + 0.3;

        int zmienna_całokowita_3 = 33;
        String convert = Convert.ToString(zmienna_całokowita_3);

        String zmienna_string = "^";
        char zmienna_char = Convert.ToChar(zmienna_string);

        String zmienna_string_2 = "true";
        bool zmienna_bool = Convert.ToBoolean(zmienna_string_2);

        Console.WriteLine($"Zmienna stała to = {zmienna_całokowita.GetType()}\n");
        Console.WriteLine($"Zmienna zmiennoprzecinkowa_2 to = {zmienna_zmiennoprzecinkowa_2}\n");
        Console.WriteLine($"Zmienna po convercie to = {convert}\n");
        Console.WriteLine($"Zmienna po convercie to = {zmienna_char}\n");
        Console.WriteLine($"Zmienna po convercie to = {zmienna_bool}\n");

    }

    static void Main(string[] args)
    {

        type_casting();

        Console.ReadKey();

    }

}