using Assignments;

Student student = new Student("RajKumar", 50, 80, 40);
Console.WriteLine($"Total=" +student.Total());
Console.WriteLine($"Average=" +student.CalculateAverage());
Console.WriteLine($"Grade=" + student.Grade());
