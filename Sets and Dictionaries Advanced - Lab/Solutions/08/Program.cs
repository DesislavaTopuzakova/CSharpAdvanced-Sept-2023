HashSet<string> reservations = new HashSet<string>();
HashSet<string> cameToThePaty = new HashSet<string>();
HashSet<string> didntCome = new HashSet<string>();

string command;

while ((command = Console.ReadLine()) != "PARTY")
{
    reservations.Add(command);
}

while ((command = Console.ReadLine()) != "END")
{
    cameToThePaty.Add(command);
}

foreach (var guest in reservations) //if reservations contains the member, but cameToTheParty doesnt
{
    //if cametotheparty !contains the guest, ++ it

    if (!cameToThePaty.Contains(guest))
    {
        didntCome.Add(guest);
    }
}

Console.WriteLine(didntCome.Count);

foreach (var item in didntCome.OrderByDescending(x => char.IsDigit(x[0])))
{
    Console.WriteLine(item);
}
