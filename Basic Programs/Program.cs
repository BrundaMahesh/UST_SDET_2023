//*********Addition of two numbers**********//
//Console.WriteLine("Enter the two numbers:");
//int firstNumber,secondNumber,Sum;
//firstNumber = Convert.ToInt32(Console.ReadLine());  
//secondNumber = Convert.ToInt32(Console.ReadLine());
//Sum=firstNumber + secondNumber;
//Console.WriteLine("Sum of two numbers=" + Sum);



//*************String Manipulation************//
//string? s1 = "";
//string? s2 = "";
//string? s3 = "";
//s1=Console.ReadLine();
//s2=Console.ReadLine();
//s3 = s1 + "" + s2;
//Console.WriteLine(s3);
//Console.WriteLine(s1.Equals(s2));
//Console.WriteLine(s1.ToUpper());
//Console.WriteLine(s1.ToLower());
//Console.WriteLine(s2.Substring(3));

//string[] s=s3.Split(' ');
//for(int i = 0; i < s.Length; i++)
//    Console.WriteLine(s[i]);


//**************Switch expression******************//
//int x = 1;
//switch (x)
//{
//    case 0:
//        Console.WriteLine("Zero");
//        break;

//    case 1:
//        Console.WriteLine("One");
//        break;

//    default:
//        Console.WriteLine("Invalid");
//        break;
//}



//*************driver*********************//
using Basic_Programs;

//Calculation calculation = new Calculation();
//int firstNumber = Convert.ToInt32(Console.ReadLine());
//int secondNumber = Convert.ToInt32(Console.ReadLine());
//double sum = calculation.Add(firstNumber, secondNumber);
//Console.WriteLine(sum);



//Electricity electricity = new Electricity(); //default constructor
//Electricity electricity= new Electricity(10001,9000,9300,"Raj"); //parameterised constructor
//Console.WriteLine($"Bill Amount=" +electricity.CalculateBill());



//Employee employee = new Employee(101, "Anusha", "IT", 10000);
//Console.WriteLine($"EmpId=" +employee.EmpId);
//Console.WriteLine($"EmpName=" +employee.EmpName);
//Console.WriteLine($"Department=" +employee.Department);
//Console.WriteLine($"Basic pay=" +employee.BasicPay);
//Console.WriteLine($"Net Salary=" +employee.CalculateSalary());

//Console.WriteLine("\nEmpId:{0}\n" + "EmpName:{1}\n" + "Department:{2}\n" + "Basic Pay:{3}", employee.EmpId,employee.EmpName,employee.Department,employee.BasicPay);
//Console.WriteLine("Net salary:{0}" ,employee.CalculateSalary());


ArraysExample arraysExample = new ArraysExample();
arraysExample.OneDimensional();
arraysExample.TwoDimensional();
