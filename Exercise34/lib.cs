namespace myLibrary
{
    class ArraysMethods
    {
        public static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        public static void fillArray(int[] arr, int minValue, int maxValue)
        {
            maxValue++;
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(minValue, maxValue);
            }
        }
    }
}