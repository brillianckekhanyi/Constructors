using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book ("Harry potter", "JK Rowling", 400);
            Console.WriteLine(book1.title);
            Console.ReadLine();
        }

    }
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle,string aAuthor,int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;

        }


    }
}
