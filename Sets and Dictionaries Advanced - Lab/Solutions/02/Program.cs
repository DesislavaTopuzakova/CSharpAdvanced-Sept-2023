int count = int.Parse(Console.ReadLine()); //брой на въведените записи

//ученик -> списък с оценки
Dictionary<string, List<decimal>> studentsGrade = new Dictionary<string, List<decimal>>();

for (int i = 1; i <= count; i++)
{
    string input = Console.ReadLine(); //"John 5.20"
    //"John 5.20".Split() -> ["John", "5.20"]
    string name = input.Split()[0]; //име на ученика
    decimal grade = decimal.Parse(input.Split()[1]); //получената оценка

    if (!studentsGrade.ContainsKey(name))
    {
        studentsGrade.Add(name, new List<decimal>());
    }

    //имаме такъв ученик в речника
    studentsGrade[name].Add(grade);
}

//ученик -> списък с оценки

foreach (var entry in studentsGrade)
{
    //entry -> key (име) : value (списък с оценките)
    string name = entry.Key;
    List<decimal> grades = entry.Value;
    decimal average = entry.Value.Average(); //grades.Average();

    Console.WriteLine($"{name} -> {String.Join(" ", grades.Select(grade => $"{grade:F2}"))} (avg: {average:F2})");
    //John -> 5.20 3.20 (avg: 4.20)
}
