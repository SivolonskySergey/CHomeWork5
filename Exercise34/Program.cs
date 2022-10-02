
void showArray(int[] arr) 
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
};


void fillArray(int[] arr, int minValue, int maxValue) 
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++) 
    {
        arr[i] = random.Next(minValue, maxValue);
    }
}

void amountOfEven()
{
    int size = 3;
    int[] numbers = new int[size];
    fillArray(numbers, 0, 10000);
    int count = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] % 2 == 0)
        {
            count+=1;
        }
    }
    showArray(numbers);
    Console.WriteLine($"Четных чисел в массиве - {count}");
}

amountOfEven();
