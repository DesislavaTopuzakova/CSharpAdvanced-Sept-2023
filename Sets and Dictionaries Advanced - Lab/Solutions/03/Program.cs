//{10 30 15 20 50 5} -> sort descending order -> {50, 30, 20, 15, 10, 5}
List<int> numbers = Console.ReadLine() //"10 30 15 20 50 5"
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse) //{10 30 15 20 50 5}
                    .OrderByDescending(n => n) //{50, 30, 20, 15, 10, 5}
                    .Take(3) //{50, 30, 20}
                    .ToList();



Console.WriteLine(String.Join(" ", numbers));


