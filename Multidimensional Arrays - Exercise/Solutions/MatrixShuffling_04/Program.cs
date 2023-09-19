int[] dimensions = Console.ReadLine() // "3 4"
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray(); // [3, 4]

int rows = dimensions[0]; //брой на редове
int cols = dimensions[1]; //брой на колони 

string[,] matrix = new string[rows, cols];

//Прочитане на матрица от конзолата
for (int row = 0; row <= rows - 1; row++) //всички редове от първия до последния
{
    string[] words = Console.ReadLine() 
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    for (int col = 0; col <= cols - 1; col++)
    {
        matrix[row, col] = words[col];
    }
}

string command = Console.ReadLine();

while (command != "END")
{
    //command = "swap row1 col1 row2 col2"
    //валидираме командата
    if (IsValidCommand(command, rows, cols))
    {
        //валидна команда -> изпълнявам командата
        string[] splittedCommand = command.Split(" ");
        int row1 = int.Parse(splittedCommand[1]); //ред на първия елемент
        int col1 = int.Parse(splittedCommand[2]); //колона на първия елемент
        int row2 = int.Parse(splittedCommand[3]); //ред на втория елемент
        int col2 = int.Parse(splittedCommand[4]); //колона на втория елемент

        string element1 = matrix[row1, col1];
        string element2 = matrix[row2, col2];

        matrix[row1, col1] = element2;
        matrix[row2, col2] = element1;

        PrintMatrix(matrix);

    }
    else
    {
        Console.WriteLine("Invalid input!");
    }

    command = Console.ReadLine(); 
}


//true -> ako командата е валидна
//false -> ако командата е невалидна
static bool IsValidCommand (String command, int rows, int cols)
{
    //command = "swap 1 2 0 3"
    string[] commandParts = command.Split(" "); //["swap", "1", "2", "0", "3"] 
    
    //1. името на командата
    bool isValidName = commandParts[0] == "swap";
    //2. брой елементите е валиден
    bool isValidCountParts = commandParts.Length == 5;

    bool isValidRowsAndCols = false;
    if (isValidName && isValidCountParts)
    {
        int row1 = int.Parse(commandParts[1]); //ред на първия елемент
        int col1 = int.Parse(commandParts[2]); //колона на първия елемент
        int row2 = int.Parse(commandParts[3]); //ред на втория елемент
        int col2 = int.Parse(commandParts[4]); //колона на втория елемент

        //3. валидни ли са редовете и колоните
        isValidRowsAndCols = row1 >= 0 && row1 < rows
                                && col1 >= 0 && col1 < cols
                                && row2 >= 0 && row2 < rows
                                && col2 >= 0 && col2 < cols;
    }
    

    return isValidName && isValidCountParts && isValidRowsAndCols;
                            
}

static void PrintMatrix (string[,] matrix)
{
    //matrix.GetLength(0) -> брой на редовете на матрица
    //matrix.GetLength(1) -> брой на колоните на матрица
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col] + " ");
        }

        Console.WriteLine();
    }
}
