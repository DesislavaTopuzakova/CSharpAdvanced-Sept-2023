//магазин -> {продукт -> цена}
SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

string command = Console.ReadLine();

while (command != "Revision")
{
    //command = "{shop}, {product}, {price}"
    string[] commandParts = command.Split(", "); //["{shop}", "{product}", "{price}"]
    string shop = commandParts[0]; //магазин
    string product = commandParts[1]; //продукт
    double price = double.Parse(commandParts[2]); //цена на продукта

    //имам ли такъв магазин
    if (!shops.ContainsKey(shop))
    {
        shops.Add(shop, new Dictionary<string, double>());
    }

    //имам такъв магазин -> добавя продукта към него
    shops[shop].Add(product, price);

    command = Console.ReadLine();
}

foreach (var entry in shops)
{
    //entry: key(име на магазина) : value (речник с продуктите)
    Console.WriteLine(entry.Key + "->");

    //entry.Value: product -> price
    foreach (var product in entry.Value)
    {
        //key: име на продукта; value: цена за продукта
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }

}