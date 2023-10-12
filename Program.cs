using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Usage: program.exe <filename>");
            return;
        }

        string filename = args[0];

        try
        {
            char[] characters = File.ReadAllText(filename).ToCharArray();
            int vowels, consonants;
            CountVowelsAndConsonants(characters, out vowels, out consonants);
            Console.WriteLine($"Number of vowels: {vowels}");
            Console.WriteLine($"Number of consonants: {consonants}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading the file.");
        }
    }

    static void CountVowelsAndConsonants(char[] characters, out int vowels, out int consonants)
    {
        vowels = 0;
        consonants = 0;

        foreach (char character in characters)
        {
            if (char.IsLetter(character))
            {
                if ("aeiouAEIOU".Contains(character))
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
        }
    }
    
    
        static void Main(string[] args)
        {
            int[,] matrix1 = {
            {1, 2, 3},
            {4, 5, 6},
        };

            int[,] matrix2 = {
            {7, 8},
            {9, 10},
            {11, 12}
        };

            int[,] result = MultiplyMatrices(matrix1, matrix2);
            Console.WriteLine("Matrix 1:");
            PrintMatrix(matrix1);
            Console.WriteLine("Matrix 2:");
            PrintMatrix(matrix2);
            Console.WriteLine("Result of Matrix Multiplication:");
            PrintMatrix(result);
        }

        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (cols1 != rows2)
            {
                throw new InvalidOperationException("Number of columns in the first matrix must be equal to the number of rows in the second matrix.");
            }

            int[,] result = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    
   
    
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] temperatures = new int[12, 30];

            
            for (int month = 0; month < 12; month++)
            {
                for (int day = 0; day < 30; day++)
                {
                    temperatures[month, day] = random.Next(-10, 41); 
                }
            }

            
            int[] averageTemperatures = CalculateAverageTemperatures(temperatures);
            Array.Sort(averageTemperatures);

            
            Console.WriteLine("Sorted Average Temperatures for Each Month:");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"Month {i + 1}: {averageTemperatures[i]}°C");
            }
        }

        static int[] CalculateAverageTemperatures(int[,] temperatures)
        {
            int[] averageTemperatures = new int[12];

            for (int month = 0; month < 12; month++)
            {
                int sum = 0;
                for (int day = 0; day < 30; day++)
                {
                    sum += temperatures[month, day];
                }
                averageTemperatures[month] = sum / 30;
            }

            return averageTemperatures;
        }
    
    static void Main()
    {
        Console.ReadKey();
    }
}