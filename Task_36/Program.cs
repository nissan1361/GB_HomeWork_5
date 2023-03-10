// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

// Logic
int[] array = RandomArr();
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

Console.WriteLine("");

int summ = FindSummNo2(array);
Console.WriteLine($"Сумма элементов на нечетных позициях = {summ}");

// Methods
static int[] RandomArr()
{
    int[] arr = new int[20];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 199);
    }

    return arr;
}

static int FindSummNo2(int[] arr)
{
    int summa = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            summa = summa + arr[i];
        }
    }

    return summa;
}
