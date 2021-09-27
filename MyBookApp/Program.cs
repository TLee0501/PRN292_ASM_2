using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookApp
{
    class Program
    {
        public static void display_menu()
        {
            Console.WriteLine("\n**********     Menu     **********");
            Console.WriteLine("1 - Add new book");
            Console.WriteLine("2 - Update a book");
            Console.WriteLine("3 - Delete a book");
            Console.WriteLine("4 - List all book");
            Console.WriteLine("Other - Quit");
        }

        public static int ChooseOption()
        {
            int choose;
            display_menu();
            Console.Write("Your choose: ");
            choose = Int32.Parse(Console.ReadLine());
            return choose;
        }
        static void Main(string[] args)
        {
            List<MyBookLibrary.Book> booklist = new List<MyBookLibrary.Book>();
            int choose;
            do
            {
                choose = ChooseOption();
                switch (choose)
                {
                    case 1:
                        MyBookLibrary.BookManager.AddNewBook(booklist);
                        break;
                    case 2:
                        MyBookLibrary.BookManager.UpdateBook(booklist);
                        break;
                    case 3:
                        MyBookLibrary.BookManager.DeleteBook(booklist);
                        break;
                    case 4:
                        MyBookLibrary.BookManager.PrintAllBook(booklist);
                        break;
                }

            } while (choose > 0 && choose < 5);
        }
    }
}
