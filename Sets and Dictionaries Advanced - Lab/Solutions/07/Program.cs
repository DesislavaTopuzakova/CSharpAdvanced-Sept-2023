string input = Console.ReadLine();
//списък с номерата на колите
HashSet<string> parking = new HashSet<string>();

while (input != "END")
{
    //input = "direction, carNumber"
    string direction = input.Split(", ")[0]; //"IN" или "OUT"
    string carNumber = input.Split(", ")[1];

    if (direction == "IN")
    {
        //колата може да влезе в паркинга
        parking.Add(carNumber);
    }

    else if (direction == "OUT")
    {
        //колата излиза от паркинга
        parking.Remove(carNumber);
    }


    input = Console.ReadLine();
}

//списък с уникални номерата на колите в паркинга
if (parking.Count == 0)
{
    //нямаме коли в паркинга
    Console.WriteLine("Parking Lot is Empty");
}
else
{
    //имаме коли в паркинга
    foreach (string carNumber in parking)
    {
        Console.WriteLine(carNumber);
    }
}