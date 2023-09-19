//КВАДРАТНА МАТРИЦА
using System.Security;

int size = int.Parse(Console.ReadLine()); // бр. редове = бр. колони

string[] directions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
//"up right right up right" -> ["up", "right", "right", "up", "right"]
//валидни посоки: left, right, up, and down.

char[,] matrix = new char[size, size];

int currentRow = 0; //ред на стартиране
int currentCol = 0; //колона на стартиране
int countCoal = 0; //брой на полезни изкопаеми


//Прочитане на матрица от конзолата
for (int row = 0; row <= size - 1; row++) //всички редове от първия до последния
{
    char[] symbols = Console.ReadLine() 
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
    for (int col = 0; col <= size - 1; col++)
    {
        matrix[row, col] = symbols[col];
        if (symbols[col] == 's')
        {
            currentRow = row;
            currentCol = col;
        } else if (symbols[col] == 'c')
        {
            countCoal++;
        }
    }
}

//Колко ползени изкопаеми имаме за събиране
foreach (string direction in directions)
{
    //direction: left, right, up, and down
    switch (direction)
    {
        case "left":
            //колона - 1
            //валидираме мястото, на което ще отидем преди преместване
            if (currentCol - 1 >= 0 && currentCol - 1 <= size - 1)
            {
                //преместване
                currentCol--;
                //проверка къде сме отишли
                char currentElement = matrix[currentRow, currentCol];
                if (currentElement == 'e')
                {
                    //прекратим цикъла с посоките
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    return;
                }
                else if (currentElement == 'c')
                {
                    //взимаме полезно изкопаемото
                    matrix[currentRow, currentCol] = '*';
                    countCoal--; //взели едно изкопаемо от матрицата
                    if (countCoal == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                        return;
                    }
                }

            }


            break; 

        case "right":
            //колона + 1
            if (currentCol + 1 >= 0 && currentCol + 1 <= size - 1)
            {
                currentCol++;
                //проверка къде сме отишли
                char currentElement = matrix[currentRow, currentCol];
                if (currentElement == 'e')
                {
                    //прекратим цикъла с посоките
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    return;
                }
                else if (currentElement == 'c')
                {
                    //взимаме полезно изкопаемото
                    matrix[currentRow, currentCol] = '*';
                    countCoal--; //взели едно изкопаемо от матрицата
                    if (countCoal == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                        return;
                    }
                }

            }

            break;

        case "up":
            //ред - 1
            if (currentRow - 1 >= 0 && currentRow - 1 <= size - 1)
            {
                currentRow--;
                //проверка къде сме отишли
                char currentElement = matrix[currentRow, currentCol];
                if (currentElement == 'e')
                {
                    //прекратим цикъла с посоките
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    return;
                }
                else if (currentElement == 'c')
                {
                    //взимаме полезно изкопаемото
                    matrix[currentRow, currentCol] = '*';
                    countCoal--; //взели едно изкопаемо от матрицата
                    if (countCoal == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                        return;
                    }
                }

            }
            break;

        case "down":
            //ред + 1
            if (currentRow + 1 >= 0 && currentRow + 1 <= size - 1)
            {
                currentRow++;
                //проверка къде сме отишли
                char currentElement = matrix[currentRow, currentCol];
                if (currentElement == 'e')
                {
                    //прекратим цикъла с посоките
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    return;
                }
                else if (currentElement == 'c')
                {
                    //взимаме полезно изкопаемото
                    matrix[currentRow, currentCol] = '*';
                    countCoal--; //взели едно изкопаемо от матрицата
                    if (countCoal == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                        return;
                    }
                }
            }
            break;
    }
}

Console.WriteLine($"{countCoal} coals left. ({currentRow}, {currentCol})");