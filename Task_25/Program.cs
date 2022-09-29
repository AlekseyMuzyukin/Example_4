Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

void Degree(int a, int b)
{
    if (b > 0)
    {
        int number = 1;
        for (int i = 1; i <= b; i++)
        {
            number = number * a;
            Console.WriteLine($"число {a} в степени {i} = {number}");
        }

    }
    else
    {
        Console.WriteLine("Введено неверное значение");
    }

}

Degree(a, b);