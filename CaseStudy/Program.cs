using CaseStudy;
using System.Reflection;
using System.Threading.Channels;

Book[] books = new Book[1];
//Customer[] customers = new Customer[1];
int option = 1;
double total;
do
{

    Console.WriteLine("Online Book Store");
    Console.WriteLine("1.Add Book");
    Console.WriteLine("2.Add Customer Details");
    Console.WriteLine("3.Place order");
    Console.WriteLine("4.Search Book");
    Console.WriteLine("5.Exit");
    Console.Write("enter your choice:");
    int choice = Convert.ToInt32(Console.ReadLine());
    
    switch (choice)
    {

        case 1:
            for (int i = 0; i < 1; i++)
            {
                Console.Write("enter book title:");
                string title = Console.ReadLine();
                Console.Write("enter book author:");
                string author = Console.ReadLine();
                Console.Write("enter book ISBN:");
                int isbn = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter book price:");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.Write("enter book availibity:");
                string availability = Console.ReadLine();
                Console.Write("enter book type:");
                string type = Console.ReadLine();
                books[i] = new Book(title, author, isbn, price, availability, type);
                Console.WriteLine("Book added successfully!!");
                foreach (var book in books)
                {
                    book.Display(book);
                }
            }
            break;

        case 2:
            Console.Write("enter customer name:");
            string name = Console.ReadLine();
            Console.Write("enter contact detail:");
            int contact = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter customer id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Customer customer=new Customer(name, contact,id);
            customer.CustDisplay();
            break;

        case 3:
            Console.Write("enter the book author to purchase:");
            string author1=Console.ReadLine();
            foreach (var item in books)
            {
                if(item.Author==author1)
                {
                    Console.Write("enter order date:");
                    int orderDate=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Order placed!!");
                    total = item.Price;
                    Order order= new Order(orderDate, total);
                    Console.WriteLine("\nOrder details:");
                    order.OrderPlaced();
                    Console.WriteLine("Book title:" + item.Title);
                    Console.WriteLine("Book price:"+item.Price);

                }
                else
                {
                    Console.WriteLine("No book with is author to order!! ");
                }
                
            }
            break;


        case 4:
            Console.Write("enter the book title to search:");
            string title1=Console.ReadLine();
            foreach (var item in books)
            {
                if(item.Title.Equals(title1))
                {
                    Console.WriteLine($"Book title:"+item.Title);
                    Console.WriteLine($"Book price:"+item.Price);
                    Console.WriteLine($"Book availability:"+item.Availability);
                }
                else
                {
                    Console.WriteLine($"Book with this title {item.Title} is not available!!");
                }
            }
            break;

        case 5:
            Console.WriteLine("Exit successful!!");
            break;
        default:
            Console.WriteLine("Invalid");
            break;
    }
    Console.WriteLine("Do you want to continue?\n 1.Yes\n 2.No");
    option = Convert.ToInt32(Console.ReadLine());
}
while (option != 2);












