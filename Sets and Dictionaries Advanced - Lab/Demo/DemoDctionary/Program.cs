//продукт -> ед. цена

Dictionary<string, double> products = new Dictionary<string, double>();

//начин 1 за добавяне на запис в речника
products.Add("banana", 2.30);
products.Add("grape", 3.50);
products.Add("carrot", 4.90);

//начин 2 за добавяне на запис в речника
products["tomato"] = 4.50;

Console.WriteLine(products["banana"]); //достъпваме стойност срещу дадения ключ

products.Remove("grape"); //премахваме запис с дадения ключ

Console.WriteLine(products.ContainsKey("cucumber")); //False
Console.WriteLine(products.ContainsKey("banana")); //True

Console.WriteLine(products.ContainsValue(5)); //False
Console.WriteLine(products.ContainsValue(2.30)); //True

Console.WriteLine(products.Count); //брой на записите


//СОРТИРАНЕ
//"banana" -> 2.30
//"carrot" -> 4.90
//"tomato" -> 4.50

//1. по ключ в ascending order (A-Z)
products.OrderBy(pair => pair.Key);
//"banana" -> 2.30
//"carrot" -> 4.90
//"tomato" -> 4.50

//2. по ключ в descending order(Z-A)
products.OrderByDescending(pair => pair.Key);
//"tomato" -> 4.50
//"carrot" -> 4.90
//"banana" -> 2.30

//3. по value в ascending order (от най-малкото към най-голямото)
products.OrderBy(pair => pair.Value);
//"banana" -> 2.30
//"tomato" -> 4.50
//"carrot" -> 4.90

//4. по value в descending order (от най-голяма към най-малка)
products.OrderByDescending(pair => pair.Value);
//"carrot" -> 4.90
//"tomato" -> 4.50
//"banana" -> 2.30

//5. сортиране по 2 параметъра
//"carrot" -> 4.90
//"corn" -> 4.50
//"tomato" -> 4.50
//"banana" -> 2.30
products
    .OrderByDescending(pair => pair.Value)
    //"carrot" -> 4.90
    //"corn" -> 4.50
    //"tomato" -> 4.50
    //"banana" -> 2.30
    .ThenBy(pair => pair.Key);
    //"carrot" -> 4.90
    //"tomato" -> 4.50
    //"corn" -> 4.50
    //"banana" -> 2.30