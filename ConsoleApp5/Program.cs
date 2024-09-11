using System.IO;
using System.Text;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Введите кол-во строк");
        int z = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите кол-во стобцов");
        int x = Convert.ToInt32(Console.ReadLine());
        int[,] matr1 = new int[z, x];
        Console.WriteLine("Введите кол-во строк");
        z = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите кол-во стобцов");
        x = Convert.ToInt32(Console.ReadLine());
        int[,] matr2 = new int[z, x];
        z = 0;
        int[,] lastMatr = new int[matr1.GetLength(0), matr2.GetLength(1)];
        if (matr1.GetLength(0) == matr2.GetLength(1))
        {
            Console.WriteLine("Введите значения матрицы 1");
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    matr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Введите значения матрицы 2");
            for (int i = 0; i < matr2.GetLength(0); i++)
            {
                for (int j = 0; j < matr2.GetLength(1); j++)
                {
                    matr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr2.GetLength(1); j++)
                {
                    int с = 0;
                    for (int k = 0; k < matr1.GetLength(1); k++)
                    {
                        с += matr1[i, k] * matr2[k, j];
                    }
                    lastMatr[i, j] = с;
                }
            }
            int[] flatArray = new int[matr1.GetLength(0) * matr2.GetLength(1)];
            int index = 0;
            for (int i = 0; i < lastMatr.GetLength(0); i++)
            {
                for (int j = 0; j < lastMatr.GetLength(1); j++)
                {
                    flatArray[index++] = lastMatr[i, j];
                }
            }
            Console.WriteLine();
            for (int i = 0; i < flatArray.Length - 1; i++)
            {
                for (int j = 0; j < flatArray.Length - i - 1; j++)
                {
                    if (flatArray[j] > flatArray[j + 1])
                    {
                        // Обмен элементов
                        int temp = flatArray[j];
                        flatArray[j] = flatArray[j + 1];
                        flatArray[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < flatArray.Length; i++)
            {
                if (i % lastMatr.GetLength(0) == 0)
                {
                    Console.WriteLine("");
                }
                Console.Write(flatArray[i] + "\t");
            }
        }
        else
        {
            Console.WriteLine("Количество стобцов матрицы 1 не равно количеству строк матрицы 2");
        }
    }
}