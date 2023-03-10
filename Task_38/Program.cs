// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

double[] array = RandomArr();
double difference = Difference(array);

Console.WriteLine($"Максимальный - минимальный элемент массива = {difference}");

static double[] RandomArr()
{
    double[] arr = new double[20];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        Random random = new Random();
        arr[i] = random.NextDouble() * (100 - 50);
    }

    return arr;
}

static double Difference(double[] arr)
{
    double arrMaxValue = arr.Max();
    double arrMinValue = arr.Min();
    double differ = arrMaxValue - arrMinValue;
    return differ;
}