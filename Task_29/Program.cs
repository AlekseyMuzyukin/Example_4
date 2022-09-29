Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
int[] Array1 = new int[a];

InputArray(Array1);
PrintArray(Array1);

void InputArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i <= array.Length - 1; i++) array[i] = rnd.Next(0, 100);
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
    Console.Write($"{array[array.Length - 1]}]");
}