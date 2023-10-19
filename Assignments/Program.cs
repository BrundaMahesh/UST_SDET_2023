using Assignments;

//Student student = new Student("RajKumar", 50, 80, 40);
//Console.WriteLine($"Total=" +student.Total());
//Console.WriteLine($"Average=" +student.CalculateAverage());
//Console.WriteLine($"Grade=" + student.Grade());


Product[] products = new Product[3];
products[0] = new Product("Bread", 50, 2);
products[1] = new Product("Milk",30,1);
products[2] = new Product("Jam",80,1);
Console.WriteLine("Product details");
Console.WriteLine("***************\n");
foreach (var item in products)
{
    item.Display();
    Console.WriteLine();
}

Console.WriteLine("Total value:");
foreach(var item in products)
{
    Console.WriteLine("Product:" +item.ProductName +" "+item.ProductValue());
}