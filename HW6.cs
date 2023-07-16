//Task 41
static void Main(string[] args)
    {
        Console.Write("Введите числа через запятую: ");
        string input = Console.ReadLine();

        string[] numbers = input.Split(',');

        int count = 0;
        foreach (string number in numbers)
        {
            int num = int.Parse(number.Trim());
            if (num > 0)
            {
                count++;
            }
        }

        Console.WriteLine("Количество чисел, больших нуля: " + count);
    }
//Task 43
static void Main (string[] args)
{
        Console.WriteLine("Введите значение b1:");
        double b1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение k1:");
        double k1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение b2:");
        double b2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение k2:");
        double k2 = double.Parse(Console.ReadLine());

        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine("Точка пересечения двух прямых: ({0}, {1})", x, y);

        Console.ReadLine();
    }