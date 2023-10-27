using Assignments;
using System.Reflection;
using static Assignments.ExceptionMessages.MyException;
//18/10/2023           
//Student student = new Student("RajKumar", 50, 80, 40);
//Console.WriteLine($"Total=" +student.Total());
//Console.WriteLine($"Average=" +student.CalculateAverage());
//Console.WriteLine($"Grade=" + student.Grade());

//19/10/2023
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


//Students[] students = new Students[]
//{
// new Students("Ajay","C", new int[] {50,40,80}),
// new Students("Sanjana","B", new int[] {70,60,80}),
// new Students("Anu","A", new int[] {90,70,80})
//};

//Console.WriteLine("Student details");
//Console.WriteLine("***************");
//foreach (var student in students)
//{
//    Console.WriteLine("Student Name:" +student.Name);
//    double[] marks = new double[3];
//    double total = 0;
//    Console.Write("Marks:");
//    for (int i = 0;i<marks.Length;i++)
//    {
//        marks[i] = student.Marks[i];
//        total = total + marks[i];
//        Console.Write(marks[i] + " ");
//    }
//    Console.WriteLine("\nTotal:" +total);
//    Console.WriteLine("Average:" + student.CalculateAverage());
//    Console.WriteLine("Grade:" + student.Grade);
//    Console.WriteLine(student.GetMarksSummary());
//}

//20/10/2023
//Single
//ElectronicsProduct electronicsProduct = new ElectronicsProduct("TV",10000,2,1);
////Console.WriteLine($"Product Name:" +electronicsProduct.ProductName 
////    + "\n" +"Price:" +electronicsProduct.Price +"\n" +"Quantity:"+electronicsProduct.Quantity);
//electronicsProduct.DisplayElectronicsProduct();
//Console.WriteLine(electronicsProduct.ProductValue()); 

////Multi-level
//DigitalProduct digitalProduct = new DigitalProduct("Mobile", 50000, 5, 6, "Mp3");
////Console.WriteLine($"Product Name:" + digitalProduct.ProductName
////    + "\n" + "Price:" + digitalProduct.Price + "\n" + "Quantity:" + digitalProduct.Quantity);
//digitalProduct.DisplayDigitalProduct();
//digitalProduct.DisplayElectronicsProduct();
//Console.WriteLine(digitalProduct.ProductValue());


////heirarchial
//ElectronicsProduct electronicsProduct1 = new ElectronicsProduct("TV", 10000, 2, 1);
//ClothingProduct clothingProduct = new ClothingProduct("T-shirt", 2500, 5, "Large");
//DigitalProduct digitalProduct1 = new DigitalProduct("Mobile", 50000, 5, 6, "Mp3");
////Console.WriteLine($"\nProduct Name:" + clothingProduct.ProductName
////    + "\n" + "Price:" + clothingProduct.Price + "\n" + "Quantity:" + clothingProduct.Quantity);
//clothingProduct.DisplayClothingProduct();
//Console.WriteLine(electronicsProduct1.ProductValue());
//Console.WriteLine(digitalProduct1.ProductValue());
//Console.WriteLine(clothingProduct.ProductValue());


//23/10/2023
//Console.Write("enter first name:");
//string firstName = Console.ReadLine();
//Console.Write("enter last name:");
//string lastName = Console.ReadLine();
//Console.Write("enter age:");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.Write("enter employee id:");
//int id = Convert.ToInt32(Console.ReadLine());
//Employee employee = new Employee(firstName, lastName, age, id);
//employee.DisplayInfo(age);

//Console.Write("enter radius:");
//double radius = Convert.ToDouble(Console.ReadLine());
//Circle circle = new Circle(radius);
//circle.Draw();
//circle.CalculateArea();
//circle.CalculatePerimeter();

//Console.Write("enter length:");
//double length = Convert.ToDouble(Console.ReadLine());
//Console.Write("enter width:");
//double width = Convert.ToDouble(Console.ReadLine());
//Rectangle rectangle = new Rectangle(length, width);
//rectangle.Draw();
//rectangle.CalculateArea();
//rectangle.CalculatePerimeter();


//25/10/2023
//InsurancePolicy insurancePolicy = new InsurancePolicy("Bhima", 723748555, 10000);
//insurancePolicy.RenewPolicy(20000);
//insurancePolicy.RenewPolicy();

//LifeInsurance lifeInsurance = new LifeInsurance("Gold", 84746563, 500000, 18);
////Console.WriteLine(lifeInsurance.CalculatePremium());
//CarInsurance carInsurance = new CarInsurance("Bheema", 764846884, 300000, "Petrol");
//Console.WriteLine(carInsurance.CalculatePremium());


//26/10/23
//Customer customer=new Customer();
//Console.WriteLine("enter phone number");
//long phoneNumber=Convert.ToInt64(Console.ReadLine());
//customer.InputPhoneNumber(phoneNumber);
//customer.DisplayCustomer();

//CallRecord callRecord = new CallRecord();
//Console.WriteLine("enter phone number");
//long phoneNumber = Convert.ToInt64(Console.ReadLine());
//callRecord.CallHistory(phoneNumber);
//callRecord.TotalNoOfCalls();

Patient patient = new Patient();
try
{
    //patient.AddPatient(1, "Harini", 150, "Sugar");
    //patient.AddPatient(2, "", 34, "BP");
    //patient.AddPatient(3, "John", 67, "");
    patient.AddPatient(4, "Tom", 78, "Thyroid");
    Patient.Display();


}
catch (CustomException ex)
{
    Console.WriteLine(ex.Message);
}




