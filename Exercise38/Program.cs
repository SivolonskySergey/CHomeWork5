
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

