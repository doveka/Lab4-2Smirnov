class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[,] 
        {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
            { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 },
            { 1, 2, 3, 4, 5, 5, 6, 7, 7, 7 },
            { 5, 3, 2, 1, 1, 1, 1, 1, 1, 1 },
            { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }
        };

        int count = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            bool isMonotonic = true;

            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] >= matrix[i - 1, j])
                {
                    isMonotonic = false;
                    break;
                }
            }

            if (isMonotonic)
            {
                count++;
            }
        }

        Console.WriteLine("Количество столбцов, элементы которых монотонно убывают: " + count);
    }
    }
    