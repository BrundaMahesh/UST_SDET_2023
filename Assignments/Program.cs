using Assignments;

//Student student = new Student("RajKumar", 50, 80, 40);
//Console.WriteLine($"Total=" +student.Total());
//Console.WriteLine($"Average=" +student.CalculateAverage());
//Console.WriteLine($"Grade=" + student.Grade());


//Product[] products = new Product[3];
//products[0] = new Product("Bread", 50, 2);
//products[1] = new Product("Milk",30,1);
//products[2] = new Product("Jam",80,1);
//Console.WriteLine("Product details");
//Console.WriteLine("***************\n");
//foreach (var item in products)
//{
//    Console.WriteLine("Product Name:" +item.ProductName);
//    Console.WriteLine("Price:" +item.Price);
//    Console.WriteLine("Quantity:" + item.Quantity);
//    Console.WriteLine("Total value:"+ item.ProductValue());
//    Console.WriteLine();
//}


Students[] students = new Students[]
{
 new Students("Ajay","C", new int[] {50,40,80}),
 new Students("Sanjana","B", new int[] {70,60,80}),
 new Students("Anu","A", new int[] {90,70,80})
};

Console.WriteLine("Student details");
Console.WriteLine("***************");
foreach (var student in students)
{
    Console.WriteLine("Student Name:" +student.Name);
    double[] marks = new double[3];
    double total = 0;
    Console.Write("Marks:");
    for (int i = 0;i<marks.Length;i++)
    {
        marks[i] = student.Marks[i];
        total = total + marks[i];
        Console.Write(marks[i] + " ");
    }
    Console.WriteLine("\nTotal:" +total);
    Console.WriteLine("Average:" + student.CalculateAverage());
    Console.WriteLine("Grade:" + student.Grade);
    Console.WriteLine(student.GetMarksSummary());
}

