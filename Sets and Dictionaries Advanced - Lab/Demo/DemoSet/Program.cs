HashSet<int> numbers = new HashSet<int>();
//УНИКАЛНИ ЕЛЕМЕНТИ - нямаме повтарящи се елементи
//1. добавяме елементи в сет
numbers.Add(12);
numbers.Add(34);
numbers.Add(12); //не се добавя, защото вече го има
numbers.Add(4); 
numbers.Add(9); 

//2. премахване на елементи
numbers.Remove(12);
numbers.RemoveWhere(x => x % 2 == 0);

//3. брой на елементите в сет
Console.WriteLine(numbers.Count);

Console.WriteLine(String.Join(" ", numbers));
Console.WriteLine(numbers.Contains(9)); //True
Console.WriteLine(numbers.Contains(91)); //False


SortedSet<string> names = new SortedSet<string>();
//елементите се сортират при добавяне в ascending order
names.Add("Pesho");
names.Add("Aleks");
names.Add("Ivan");



