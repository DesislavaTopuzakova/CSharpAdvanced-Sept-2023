using System.Drawing;

int[] dimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray(); // [3, 4]

int rows = dimensions[0]; //брой на редове
int cols = dimensions[1]; //брой на колони 

char[,] matrix = new char[rows, cols];

//Прочитане на матрица от конзолата
for (int row = 0; row <= rows - 1; row++) //всички редове от първия до последния
{
    char[] symbols = Console.ReadLine() //"11 2 4"
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
    for (int col = 0; col <= cols - 1; col++)
    {
        matrix[row, col] = symbols[col];
    }
}

//БРОЙ НА МАТРИЦИТЕ 2х2
int count = 0; // брой на матрици

for (int row = 0; row < rows - 1; row++) //не включваме елементите на последния ред
{
    for (int col = 0; col < cols - 1; col++) //не включваме елементите на последната колона
    {
        int element = matrix[row, col];
        //1. дали съвпада с този в дясно -> колона + 1
        bool isEqualRight = element == matrix[row, col + 1];
        //2. дали съвпада с този отдолу -> ред + 1
        bool isEqualDown = element == matrix[row + 1, col];
        //3. дали съвпада с този по диагонал
        bool isEqualDiagonal = element == matrix[row + 1, col + 1];

        if (isEqualRight && isEqualDown && isEqualDiagonal)
        {
            count++;
        }
    }
}

Console.WriteLine(count);
