//КВАДРАТНА МАТРИЦА
int size = int.Parse(Console.ReadLine()); //бр.редове = бр. колони

//? размерът е 1 или 2 -> < 3
if (size < 3)
{
    Console.WriteLine(0);
    return;
}

int countRemoved = 0; //брой премахнати коне

char[,] matrix = new char[size, size]; //поле за игра

//Прочитане на матрица от конзолата
for (int row = 0; row <= size - 1; row++) //всички редове от първия до последния
{
    char[] symbols = Console.ReadLine().ToArray();
    for (int col = 0; col <= size - 1; col++)
    {
        matrix[row, col] = symbols[col];
    }
}

//обхождаме полето и премахваме коне, докато не останем само с добри коне = атакуват 0 други коне
while (true)
{
    int maxAttack = 0; //брой на максималните атаки от кон
    int rowMaxAttack = 0; //ред на най-атакуващия кон
    int colMaxAttack = 0; //колона на най-атакуващия кон

    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            char currentElement = matrix[row, col];
            if (currentElement == 'K')
            {
                //кон
                //1. при движения колко коня атакуване (натъпване при преместване)
                int countAttackedKnights = CalculateAttackedKnight(row, col, size, matrix);
                //2. проверка дали е най-атакуващия 
                if (countAttackedKnights > maxAttack) //кой е коня с най-много атаки
                {
                    maxAttack = countAttackedKnights;
                    rowMaxAttack = row;
                    colMaxAttack = col;
                }


            }
        }
    }
    //намеря най-атакуващия кон
    if (maxAttack == 0)
    {
        // нямам коне, които да атакуват
        break;
    } 
    else
    {
        //имам кон за премахване
        matrix[rowMaxAttack, colMaxAttack] = '0';
        countRemoved++;
    }
}

Console.WriteLine(countRemoved);


//брой на атакуваните коне от текущия кон

static int CalculateAttackedKnight (int row, int col, int size, char[, ] matrix)
{
    int count = 0;
    //2 нагоре и 1 надясно -> ред - 2, колона + 1
    if (IsValid(row - 2, col + 1, size))
    {
        //съществуват такива ред и колона -> проверка дали има кон
        if (matrix[row - 2, col + 1] == 'K')
        {
            count++;
        }
    }
    //2 нагоре и 1 наляво -> ред - 2, кол - 1
    if (IsValid(row - 2, col - 1, size))
    {
        //съществуват такива ред и колона -> проверка дали има кон
        if (matrix[row - 2, col - 1] == 'K')
        {
            count++;
        }
    }
    //2 надолу и 1 наляво -> ред + 2, колона - 1
    if (IsValid(row + 2, col - 1, size))
    {
        //съществуват такива ред и колона -> проверка дали има кон
        if (matrix[row + 2, col - 1] == 'K')
        {
            count++;
        }
    }
    //2 надолу и 1 надясно -> ред + 2, колона + 1
    if (IsValid(row + 2, col + 1, size))
    {
        //съществуват такива ред и колона -> проверка дали има кон
        if (matrix[row + 2, col + 1] == 'K')
        {
            count++;
        }
    }
    //2 надясно и 1 надолу 0 -> ред + 1, колона + 2
    if (IsValid(row + 1, col + 2, size))
    {
        //съществуват такива ред и колона -> проверка дали има кон
        if (matrix[row + 1, col + 2] == 'K')
        {
            count++;
        }
    }

    //2 надясно и 1 нагоре->ред - 1, колона + 2
    if (IsValid(row - 1, col + 2, size))
    {
        //съществуват такива ред и колона -> проверка дали има кон
        if (matrix[row - 1, col + 2] == 'K')
        {
            count++;
        }
    }

    // 2 наляво и 1 нагоре -> ред - 1, колона - 2
    if (IsValid(row - 1, col - 2, size))
    {
        //съществуват такива ред и колона -> проверка дали има кон
        if (matrix[row - 1, col - 2] == 'K')
        {
            count++;
        }
    }

    // 2 наляво и 1 надолу -> ред + 1, колона + 2
    if (IsValid(row + 1, col + 2, size))
    {
        //съществуват такива ред и колона -> проверка дали има кон
        if (matrix[row + 1, col + 2] == 'K')
        {
            count++;
        }
    }

    return count;

}

static bool IsValid(int row, int col, int size)
{
    return row >= 0 && row < size && col >= 0 && col < size;
}
