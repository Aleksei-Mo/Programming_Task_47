// Task 47. Задайте двумерный массив размером m x n , заполненны случайными вещественными числами.
Console.Clear();
Console.WriteLine("This program generates an array m x n and fills it up with float numbers.");
Console.Write("Enter number of columns: ");
int numberCol = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of rows: ");
int numberRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter lower limit for random range: ");
int lowerLim = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter upper limit for random range: ");
int upperLim = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter precision for numbers: ");
int precision = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[numberCol, numberRow];

for (int i = 0; i < randomArray.GetLength(0); i++)
{
    for (int j = 0; j < randomArray.GetLength(1); j++)
    {
        double randomNum = new Random().NextDouble()* (upperLim - lowerLim);
        randomArray[i, j] = Math.Round(randomNum,precision);
    }
}
printArray(randomArray);

void printArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}