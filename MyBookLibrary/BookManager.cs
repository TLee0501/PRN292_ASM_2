using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookLibrary
{
    public class Book
    {
        string id;
        string name;
        string publisher;
        int price;
        public Book()
        {
            this.id = id;
            this.name = name;
            this.publisher = publisher;
            this.price = price;
        }
        public Book(string id, string name, string publisher, int price)
        {
            this.id = id;
            this.name = name;
            this.publisher = publisher;
            this.price = price;
        }
        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string NAME
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string PUBLISHER
        {
            get
            {
                return publisher;
            }
            set
            {
                publisher = value;
            }
        }
        public int PRICE
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
    public class BookManager
    {

        public static void AddNewBook(List<Book> list)
        {
            Console.WriteLine("------------------ AddNew --------------------");
            Console.Write("BookID: ");
            String id = Console.ReadLine();
            BookManager bm = new BookManager();
            if (bm.checkid(list, id))
            {
                try
                {   
                    Console.Write("Book Name: ");
                    String name = Console.ReadLine();
                    Console.Write("Publisher: ");
                    String publisher = Console.ReadLine();
                    Console.Write("Price: ");
                    int price = int.Parse(Console.ReadLine());
                    Book book = new Book();
                    book = new Book(id, name, publisher, price);
                    list.Add(book);
                }
                catch
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            else
            {
                Console.WriteLine("Please choose another ID");
            }
                
        }
        public static void UpdateBook(List<Book> list)
        {
            bool found = false;
            Console.WriteLine("------------------ Update --------------------");
            Console.Write("ID: ");
            string id = Console.ReadLine();
            BookManager bm = new BookManager();
            if (bm.checkid(list, id) == false)
            {
                try
                {
                    Console.Write("Name: ");
                    string n = Console.ReadLine();
                    Console.Write("Publisher: ");
                    string pu = Console.ReadLine();
                    Console.Write("Price: ");
                    int pr = int.Parse(Console.ReadLine());
                    foreach(var up in list.Where(x => x.ID == id))
                    {
                        up.NAME = n;
                        up.PUBLISHER = pu;
                        up.PRICE = pr;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            else
                Console.WriteLine("Please check your BookID.");
        }
        public static void DeleteBook(List<Book> list)
        {
            Console.WriteLine("------------------ Delete --------------------");
            Console.Write("ID: ");
            string id = Console.ReadLine();
            BookManager bm = new BookManager();
            if (bm.checkid(list, id))
            {
                Console.WriteLine("Please check your BookID.");
            }
            else
            {
                var num = list.Single(r => r.ID == id);
                list.Remove(num);
            }
        }
        public static void PrintAllBook(List<Book> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("\nEmpty list!");
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine("STT: " + i + " --------------------------------------");
                    Console.WriteLine("ID: " + list[i].ID);
                    Console.WriteLine("Name: " + list[i].NAME);
                    Console.WriteLine("Publisher:" + list[i].PUBLISHER);
                    Console.WriteLine("Price: " + list[i].PRICE);
                }

            }
        }
        public bool checkid(List<Book> list, string id)
        {
            bool result = true;

            for (int i = 0; i < list.Count; i++)
                if (list[i].ID == id)
                {
                    result = false;
                }
            return result;
        }
    }
}
