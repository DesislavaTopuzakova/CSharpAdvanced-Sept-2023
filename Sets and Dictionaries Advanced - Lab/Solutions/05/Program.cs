int n = int.Parse(Console.ReadLine());
Dictionary<string, Dictionary<string, List<string>>> dictionary =
    new Dictionary<string, Dictionary<string, List<string>>>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    string continent = input[0];
    string country = input[1];
    string city = input[2];

    if (!dictionary.ContainsKey(continent))
    {
        dictionary[continent] = new Dictionary<string, List<string>>();
    }
    if (!dictionary[continent].ContainsKey(country))
    {
        dictionary[continent][country] = new List<string>();
    }
    dictionary[continent][country].Add(city);
}

foreach (var contintet in dictionary)
{
    Console.WriteLine(contintet.Key + ":");
    foreach (var countires in contintet.Value)
    {
        Console.Write($"{countires.Key} -> ");
        Console.WriteLine(string.Join(", ", countires.Value));
    }
}