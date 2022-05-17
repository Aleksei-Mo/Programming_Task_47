// Task 47. Задайте двумерный массив размером m x n , заполненны случайными вещественными числами.
Console.Clear();
Console.WriteLine("This program generates an array m x n and fills it up with float numbers.");
int numberRow = EnterUserData("Enter number of rows:");
int numberCol = EnterUserData("Enter number of columns:");
int lowerLim = EnterUserData("Enter lower limit for random range:");
int upperLim = EnterUserData("Enter upper limit for random range:");
int precision = EnterUserData("Enter precision for numbers: ");
double[,] randomArray = new double[numberRow, numberCol];

for (int i = 0; i < randomArray.GetLength(0); i++)
{
    for (int j = 0; j < randomArray.GetLength(1); j++)
    {
        double randomNum = new Random().NextDouble() * (upperLim - lowerLim);
        randomArray[i, j] = Math.Round(randomNum, precision);
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

int EnterUserData(string nameUserData)
{
    Console.Write($"{nameUserData}");
    return Convert.ToInt32(Console.ReadLine());
}