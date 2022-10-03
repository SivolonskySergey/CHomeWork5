namespace myLib
{
    class ArrayMethods 
    {
        public static void printArray(double[] arrayToPrint)
        {
            for (int i = 0; i < arrayToPrint.Length; i++)
            {
                Console.Write($"{arrayToPrint[i]} ");
            }
            Console.WriteLine();
        }

        public static void fillArray(double[] arrayToFill)
        {
            Random random = new Random();
            for (int i = 0; i < arrayToFill.Length; i++)
            {
                int minus = random.Next(-1,2);
                double newValue = random.NextDouble();
                if(minus != 0) {
                arrayToFill[i] = Math.Round((newValue * 100), 2) * minus;
                }
                else
                {
                    arrayToFill[i] = Math.Round((newValue * 100), 2);
                }
            }
        }

        public static double getMaxValue(double[] array)
        {
            double max = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if(array[i] > max) 
                {
                    max = array[i];
                }
            }
            return max;
        }
        public static double getMinValue(double[] array)
        {
            double min = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if(array[i] < min) 
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}