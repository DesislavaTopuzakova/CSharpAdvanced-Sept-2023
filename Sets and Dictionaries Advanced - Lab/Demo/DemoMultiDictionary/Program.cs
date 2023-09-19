//ученик -> списък с оценки

Dictionary<string, List<double>> studentsGrade = new Dictionary<string, List<double>>();

studentsGrade.Add("Stefan", new List<double>() { 5.4, 6, 3.2, });

studentsGrade.Add("Aleks", new List<double>());
//Aleks -> {}
studentsGrade["Aleks"].Add(4.50);
studentsGrade["Aleks"].Add(3.60);
//Aleks -> {4.50, 3.60}