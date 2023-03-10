// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

//////////////////////

// Logic
int[] array = RandomArr();
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

Console.WriteLine("");

int count = Find2(array);
Console.WriteLine($"Четных чисел в массиве -> {count}");

// Methods
static int[] RandomArr()
{
    int[] arr = new int[20];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 400);
    }

    return arr;
}

static int Find2(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}