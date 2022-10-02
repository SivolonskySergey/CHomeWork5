using myLibrary;

void amountOfEven()
{
    int size = 3;
    int[] numbers = new int[size];
    ArraysMethods.fillArray(numbers, 0, 10000);
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count += 1;
        }
    }
    ArraysMethods.printArray(numbers);
    Console.WriteLine($"Четных чисел в массиве - {count}");
}

amountOfEven();