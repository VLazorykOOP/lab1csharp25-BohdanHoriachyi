static void task1()
{
    Console.Write("Введіть перше число: ");
    double a = Math.Abs(Convert.ToDouble(Console.ReadLine()));
    Console.Write("Введіть друге число: ");
    double b = Math.Abs(Convert.ToDouble(Console.ReadLine()));

    double geometricMean = Math.Sqrt(a * b);
    Console.WriteLine($"Середнє геометричне: {geometricMean}");
}
static void task2()
{
    Console.Write("Введіть ціле число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (Math.Abs(num) % 10 == 7)
    {
        Console.WriteLine("Так");
    }
    else
    {
        Console.WriteLine("Ні");
    }
}

static void task3()
{
    Console.Write("Введіть x: ");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введіть y: ");
    double y = Convert.ToDouble(Console.ReadLine());

    double r1 = 3, r2 = 7;
    double distance = Math.Sqrt(x * x + y * y);

    if (distance > r1 && distance < r2)
    {
        Console.WriteLine("Так");
    }
    else if (distance == r1 || distance == r2)
    {
        Console.WriteLine("На межі");
    }
    else
    {
        Console.WriteLine("Ні");
    }
}

static void task4()
{
    Console.Write("Введіть номер масті (1-4): ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введіть номер карти (6-14): ");
    int k = Convert.ToInt32(Console.ReadLine());

    string[] suits = { "пік", "треф", "бубен", "червей" };
    string[] ranks = { "шістка", "сімка", "вісімка", "дев'ятка", "десятка", "валет", "дама", "король", "туз" };

    if (m < 1 || m > 4 || k < 6 || k > 14)
    {
        Console.WriteLine("Некоректні дані");
    }
    else
    {
        Console.WriteLine($"{ranks[k - 6]} {suits[m - 1]}");
    }
}
static void task5()
{
    Console.Write("Введіть перше число: ");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введіть друге число: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    double result = (num1 + num2);
    Console.WriteLine($"Сума: {result}");
}
static void task6()
{
    Console.Write("Введіть ціле число n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введіть ціле число m: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введіть число s: ");
    double s = Convert.ToDouble(Console.ReadLine());

    double numerator = (n + 1) / (double)(m + 1) + s;
    double denominator = m / (double)n;
    double result = (n + m) * (numerator / denominator);

    Console.WriteLine($"Результат: {result}");

}
static void ChooseTask()
{
    Console.WriteLine("0 - Task_1");
    Console.WriteLine("1 - Task_2");
    Console.WriteLine("2 - Task_3");
    Console.WriteLine("3 - Task_4");
    Console.WriteLine("4 - Task_5");
    Console.WriteLine("5 - Task_6\n");
    string _task = Console.ReadLine();
    int task;

    if (int.TryParse(_task, out task) && task >= 0 && task <= 5)
    {
        task = int.Parse(_task);
        switch (task)
        {
            case 0:
                task1();
                break;
            case 1:
                task2();
                break;
            case 2:
                task3();
                break;
            case 3:
                task4();
                break;
            case 4:
                task5();
                break;
            case 5:
                task6();
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input");
    }

}

ChooseTask();
