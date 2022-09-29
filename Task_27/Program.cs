Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int NumName(int num)
{
    int counter = Convert.ToString(num).Length; ;
    int sum = 0;
    int number = 0;
    for (int i = 0; i < counter; i++)
    {
        number = num % 10;
        sum = sum + number;
        num = num / 10;
    }
    return sum;
}
int result = NumName(num);
Console.WriteLine($"Сумма цифр числа {num} = {result}");