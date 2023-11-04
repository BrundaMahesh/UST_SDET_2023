using CaseStudy;
using CaseStudy.CustomException;
using System.Reflection;
using System.Threading.Channels;

//Book[] books = new Book[1];
////Customer[] customers = new Customer[1];
//int option = 1;
//double total;
//do
//{

//    Console.WriteLine("Online Book Store");
//    Console.WriteLine("1.Add Book");
//    Console.WriteLine("2.Add Customer Details");
//    Console.WriteLine("3.Place order");
//    Console.WriteLine("4.Search Book");
//    Console.WriteLine("5.Exit");
//    Console.Write("enter your choice:");
//    int choice = Convert.ToInt32(Console.ReadLine());

//    switch (choice)
//    {

//        case 1:
//            for (int i = 0; i < 1; i++)
//            {
//                Console.Write("enter book title:");
//                string title = Console.ReadLine();
//                Console.Write("enter book author:");
//                string author = Console.ReadLine();
//                Console.Write("enter book ISBN:");
//                int isbn = Convert.ToInt32(Console.ReadLine());
//                Console.Write("enter book price:");
//                double price = Convert.ToDouble(Console.ReadLine());
//                Console.Write("enter book availibity:");
//                string availability = Console.ReadLine();
//                Console.Write("enter book type:");
//                string type = Console.ReadLine();
//                books[i] = new Book(title, author, isbn, price, availability, type);
//                Console.WriteLine("Book added successfully!!");
//                foreach (var book in books)
//                {
//                    book.Display(book);
//                }
//            }
//            break;

//        case 2:
//            Console.Write("enter customer name:");
//            string name = Console.ReadLine();
//            Console.Write("enter contact detail:");
//            int contact = Convert.ToInt32(Console.ReadLine());
//            Console.Write("enter customer id:");
//            int id = Convert.ToInt32(Console.ReadLine());
//            Customer customer=new Customer(name, contact,id);
//            customer.CustDisplay();
//            break;

//        case 3:
//            Console.Write("enter the book author to purchase:");
//            string author1=Console.ReadLine();
//            foreach (var item in books)
//            {
//                if(item.Author==author1)
//                {
//                    Console.Write("enter order date:");
//                    int orderDate=Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine("Order placed!!");
//                    total = item.Price;
//                    Order order= new Order(orderDate, total);
//                    Console.WriteLine("\nOrder details:");
//                    order.OrderPlaced();
//                    Console.WriteLine("Book title:" + item.Title);
//                    Console.WriteLine("Book price:"+item.Price);

//                }
//                else
//                {
//                    Console.WriteLine("No book with is author to order!! ");
//                }

//            }
//            break;


//        case 4:
//            Console.Write("enter the book title to search:");
//            string title1=Console.ReadLine();
//            foreach (var item in books)
//            {
//                if(item.Title.Equals(title1))
//                {
//                    Console.WriteLine($"Book title:"+item.Title);
//                    Console.WriteLine($"Book price:"+item.Price);
//                    Console.WriteLine($"Book availability:"+item.Availability);
//                }
//                else
//                {
//                    Console.WriteLine($"Book with this title {item.Title} is not available!!");
//                }
//            }
//            break;

//        case 5:
//            Console.WriteLine("Exit successful!!");
//            break;
//        default:
//            Console.WriteLine("Invalid");
//            break;
//    }
//    Console.WriteLine("Do you want to continue?\n 1.Yes\n 2.No");
//    option = Convert.ToInt32(Console.ReadLine());
//}
//while (option != 2);



//try
//{

//    Customers customers1 = new Customers();
//    customers1.CustomerID = 10;
//    customers1.CustomerName = "Ashwin Gopal";
//    customers1.CustomerEmail = "ashwin@gmail.com";
//    Customers.customers.Add(customers1);

//    Customers customers2 = new Customers();
//    customers2.CustomerID = 2;
//    customers2.CustomerName = "Dev Surya";
//    customers2.CustomerEmail = "devSurya@gmail.com";
//    Customers.customers.Add(customers2);

//    Customers customer3 = new Customers();
//    customer3.CustomerID = 3;
//    customer3.CustomerName = "Arun Kumar";
//    customer3.CustomerEmail = "arun@gmail.com";
//    Customers.customers.Add(customer3);
//    Console.WriteLine("*****E-Commerce Order fullfillment System*****\n");
//    while (true)
//    {
//        Console.WriteLine("choose your option:\n1.User\n2.Admin");
//        int option = Convert.ToInt32(Console.ReadLine());
//        if (option == 1)
//        {
//            Console.Write("enter customer id:");
//            int cusId = Convert.ToInt32(Console.ReadLine());
//            if (Customers.customers.Find(x => x.CustomerID == cusId) == null)
//            {
//                Console.WriteLine("Customer not found!!");
//                break;
//            }
//            Console.WriteLine("choose your option\n1.Add product to cart\n2.view all product\n3.place order\n4.Support\n5.view orders");
//            int optionuser = Convert.ToInt32(Console.ReadLine());
//            switch (optionuser)
//            {

//                case 1:

//                    Console.Write("enter product id to add product to the cart:");
//                    int productId = Convert.ToInt32(Console.ReadLine());
//                    Customers customer1 = Customers.customers.Find(x => x.CustomerID == cusId);
//                    if (DigitalProduct.Products.Find(x => x.ProductID == productId) == null)
//                    {
//                        if (PhysicalProduct.Products.Find(x => x.ProductID == productId) == null)
//                        {
//                            Console.WriteLine("Invalid product id");
//                        }
//                        else
//                        {
//                            customer1.ordersphy.Add(PhysicalProduct.Products.Find(x => x.ProductID == productId));
//                            Console.WriteLine("Product successfully added to cart!!");
//                        }
//                    }
//                    else
//                    {
//                        customer1.orders.Add(DigitalProduct.Products.Find(x => x.ProductID == productId));
//                        Console.WriteLine("Product successfully added to cart!!");
//                    }
//                    break;
//                case 2:
//                    Console.WriteLine("Products are:");
//                    if (DigitalProduct.Products.Count == 0 && PhysicalProduct.Products.Count == 0)
//                    {
//                        Console.WriteLine("No product found");
//                    }
//                    foreach (var item in DigitalProduct.Products)
//                    {
//                        Console.WriteLine("Product id:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductID,
//                            item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
//                    }
//                    foreach (var item in PhysicalProduct.Products)
//                    {
//                        Console.WriteLine("Product id:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
//                            "\tDimension:{5}", item.ProductID,
//                            item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimensions);
//                    }
//                    break;
//                case 3:
//                    Customers customer = Customers.customers.Find(x => x.CustomerID == cusId);
//                    if (customer.orders.Count == 0 && customer.ordersphy.Count == 0)
//                    {
//                        Console.WriteLine("No product found in the cart");
//                    }
//                    else
//                    {
//                        foreach (var item in customer.orders)
//                        {
//                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductID,
//                             item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
//                            item.PlacingOrder();
//                            item.ProceesingPayment();
//                            item.DeliveringProduct();

//                        }
//                        foreach (var item in customer.ordersphy)
//                        {
//                            Console.WriteLine("Product id:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
//                           "\tDimension:{5}", item.ProductID, item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimensions);
//                            item.PlacingOrder();
//                            item.ProceesingPayment();
//                            item.DeliveringProduct();
//                        }
//                        Console.WriteLine("Do you want to place order?\n1.yes\n2.no");
//                        int confirm = Convert.ToInt32(Console.ReadLine());
//                        if (confirm == 1)
//                        {
//                            customer.confirmedorders.AddRange(customer.orders);
//                            customer.orders.Clear();
//                            customer.confirmedordersphy.AddRange(customer.ordersphy);
//                            customer.ordersphy.Clear();
//                            Console.WriteLine("Order successfully placed");
//                        }
//                        else
//                        {
//                            Console.WriteLine("Removing all products from cart");
//                        }

//                    }
//                    break;
//                case 4:
//                    Console.WriteLine("For support call this number 080-3455643");
//                    break;
//                case 5:
//                    Customers customer2 = Customers.customers.Find(x => x.CustomerID == cusId);
//                    if (customer2.confirmedorders.Count == 0 && customer2.confirmedordersphy.Count == 0)
//                    {
//                        Console.WriteLine("No order details found");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Orders are:");
//                        foreach (var item in customer2.confirmedorders)
//                        {
//                            Console.WriteLine("Product id:{0}\tProduct name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductID,
//                            item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
//                        }
//                        foreach (var item in customer2.confirmedordersphy)
//                        {
//                            Console.WriteLine("Product id:{0}\tProduct name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
//                           "\tDimension:{5}", item.ProductID, item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimensions);
//                        }
//                    }
//                    break;
//                default:
//                    Console.WriteLine("Invalid input");
//                    break;
//            }

//            Console.WriteLine("Do you want to continue as user?\n1.yes\n2.no");
//            int optUser = Convert.ToInt32(Console.ReadLine());
//            if (optUser == 1)
//            {
//                continue;
//            }
//            else if (optUser == 2)
//            {
//                break;
//            }
//            else
//            {
//                Console.WriteLine("Invalid input");
//            }


//        }
//        else if (option == 2)
//        {
//            Console.WriteLine("choose option\n1.Add Product");
//            int optionadmin = Convert.ToInt32(Console.ReadLine());
//            if (optionadmin == 1)
//            {
//                Console.WriteLine("choose the option \n1.Digital Product\n2.Physical Product");
//                int optionProduct = Convert.ToInt32(Console.ReadLine());
//                if (optionProduct == 1)
//                {
//                    Console.Write("enter product id:");
//                    int productid = Convert.ToInt32(Console.ReadLine());
//                    Console.Write("enter product name:");
//                    string? productName = Console.ReadLine();
//                    Console.Write("enter the price:");
//                    double productCost = Convert.ToDouble(Console.ReadLine());
//                    Console.Write("enter the fileformat:");
//                    string? fileFormat = Console.ReadLine();
//                    Console.Write("enter the downloadLink:");
//                    string? downloadLink = Console.ReadLine();


//                    DigitalProduct digitalProduct = new DigitalProduct();
//                    digitalProduct.Name = productName;
//                    digitalProduct.ProductID = productid;
//                    digitalProduct.FileFormat = fileFormat;
//                    digitalProduct.DownloadLink = downloadLink;
//                    digitalProduct.Price = productCost;
//                    DigitalProduct.AddProduct(digitalProduct);
//                    DigitalProduct.Products.Add(digitalProduct);
//                }
//                else if (optionProduct == 2)
//                {
//                    Console.Write("enter product id:");
//                    int productid = Convert.ToInt32(Console.ReadLine());
//                    Console.Write("enter product name:");
//                    string? productName = Console.ReadLine();
//                    Console.Write("enter the price:");
//                    double productCost = Convert.ToDouble(Console.ReadLine());
//                    Console.Write("enter the weight:");
//                    int weight = Convert.ToInt32(Console.ReadLine());
//                    Console.Write("enter the dimension:");
//                    string? dimension = Console.ReadLine();

//                    PhysicalProduct physicalProduct = new PhysicalProduct();
//                    physicalProduct.Name = productName;
//                    physicalProduct.ProductID = productid;
//                    physicalProduct.Price = productCost;
//                    physicalProduct.Dimensions = dimension;
//                    physicalProduct.Weight = weight;
//                    PhysicalProduct.AddProduct1(physicalProduct);
//                    PhysicalProduct.Products.Add(physicalProduct);
//                }
//                else
//                {
//                    Console.WriteLine("Invalid input");
//                }
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid option");
//        }
//        Console.WriteLine("Do you want to continue?\n1.yes\n2.no");
//        int opt = Convert.ToInt32(Console.ReadLine());
//        if (opt == 1)
//        {
//            continue;
//        }
//        else if (opt == 2)
//        {
//            Environment.Exit(0);
//        }
//        else
//        {
//            Console.WriteLine("Invalid input");
//        }

//    }
//}
//catch(OrderException ex)
//{
//    Console.WriteLine(ex.Message);
//}



//04/11/2023

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("*********Student Enrollment System***********");
        Console.WriteLine("1.Admin\n2.Student");
        int choice=Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine("Choose option\n1.Add Course\n2.Generate Report");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.Write("enter course code:");
                    int code = Convert.ToInt32(Console.ReadLine());
                    Console.Write("enter course title:");
                    string? title = Console.ReadLine();
                    Console.Write("enter the instructor:");
                    string? instructor = Console.ReadLine();
                    Console.Write("enter maximum count:");
                    int maxCount = Convert.ToInt32(Console.ReadLine());
                    Course course = new Course();
                    course.CourseCode = code;
                    course.Title = title;
                    course.Instructor = instructor;
                    course.MaxCount = maxCount;
                    Course.courses.Add(course);
                    break;

                case 2:
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            
        }
        

        if (choice == 2)
        {
            Console.Write("Choose option:\n1.Student Registration\n2.Course Registration\n3.Course Withdrawal\n4.Exit\n");
            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.Write("enter student id:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("enter student name:");
                    string? name = Console.ReadLine();
                    Console.Write("enter email:");
                    string? email = Console.ReadLine();
                    Student student = new Student();
                    student.StudentId = id;
                    student.Name = name;
                    student.Email = email;
                    student.studentList.Add(student);
                    break;

                case 2:
                    Console.WriteLine("Choose the course you want to enroll:");
                    Course course= new Course();
                    Student student1 = new Student();
                    course.CourseRegistration(course, student1);
                    break;

                case 3:
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }

        }

    }
}















