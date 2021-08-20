using System;

namespace Lesson7_19_08_2021
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double ParameterRectangle()
        {
            var p = (side1 + side2) * 2;
            return p;
        }

        public double AreaRectangle()
        {
            var a = (side1 * side2);
            return a;
        }

        public double Perimeter
        {
            get { return ParameterRectangle(); }
        }

        public double Area
        {
            get { return AreaRectangle(); }
        }
    }

    class Book
    {
        public Content MyCont { get; set; }
        public Title MyTitle { get; set; }
        public Author MyAuthor { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            MyAuthor.Show();
            Console.ForegroundColor = ConsoleColor.Green;
            MyTitle.Show();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            MyCont.Show();
        }

        public Book()
        {
            MyAuthor = new Author();
            MyTitle = new Title();
            MyCont = new Content();
        }

        public Book(string autName, string bookTitle, string bookContent)
        {
            MyAuthor = new Author();
            MyTitle = new Title();
            MyCont = new Content();
            MyCont.BookContent = bookContent;
            MyAuthor.AutName = autName;
            MyTitle.BookName = bookTitle;
        }
    }

    class Title
    {
        public string BookName { get; set; }

        public void Show()
        {
            Console.WriteLine("Название: " + BookName);
        }
    }

    class Author
    {
        public string AutName { get; set; }

        public void Show()
        {
            Console.WriteLine("Автор: " + AutName);
        }
    }

    class Content
    {
        public string BookContent { get; set; }

        public void Show()
        {
            Console.WriteLine("Содержание: " + BookContent);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1

            Console.Write("side1 = ");
            var side1 = double.Parse(Console.ReadLine());
            Console.Write("side2 = ");
            var side2 = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            var parameter = rectangle.ParameterRectangle();
            Console.WriteLine(parameter);
            var area = rectangle.AreaRectangle();
            Console.WriteLine(area);

            //задача2
            Book book;
            Console.Write("Введите имя автора:  ");
            string Author = Console.ReadLine();
            Console.Write("Введите название книги:  ");
            string Title = Console.ReadLine();
            Console.Write("Введите содержание книги: ");
            string content = Console.ReadLine();
            book = new Book(Author, Title, content);
            book.Show();
            Console.ReadKey();
        }
    }
}