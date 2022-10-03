// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3,21 7,04 22,93 -2,71 78,24] -> max = 78,24, min = - 2,71, difference = 80,95

using myLib;

void MinMaxDiff() 
{
    Random randomSize = new Random();
    int size = randomSize.Next(5, 11);
    double[] numbers = new double[size];
    ArrayMethods.fillArray(numbers);
    ArrayMethods.printArray(numbers);
    double max = ArrayMethods.getMaxValue(numbers);
    double min = ArrayMethods.getMinValue(numbers);
    Console.WriteLine($"max = {max}, min = {min}, difference = {max - min}");
}

MinMaxDiff();

