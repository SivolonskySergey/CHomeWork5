namespace myLib
{
    class ArrayMethods 
    {
        public static void printArray(int[] arrayToPrint)
        {
            for (int i = 0; i < arrayToPrint.Length; i++)
            {
                Console.Write($"{arrayToPrint[i]} ");
            }
            Console.WriteLine();
        }

        public static void fillArray(int[] arrayToFill, int minValue, int maxValue)
        {
            maxValue++;
            Random random = new Random();
            for (int i = 0; i < arrayToFill.Length; i++)
            {
                arrayToFill[i] = random.Next(minValue, maxValue);
            }
        }
    }
}