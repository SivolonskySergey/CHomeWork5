
using myLib;

void sumOfUnevenIndex()
{
    Random randomSize = new Random();
    int size = randomSize.Next(5, 11);
    int[] numbers = new int[size];
    ArrayMethods.fillArray(numbers, -1000, 1000);
    int summ = 0;
    for(int i = 1; i < numbers.Length; i+=2)
    {
        if(i % 2 != 0) 
        {
            summ+= numbers[i];
        }
    }
    ArrayMethods.printArray(numbers);
    Console.WriteLine($"Сумма чисел с нечетными индексами - {summ}");
}

sumOfUnevenIndex();