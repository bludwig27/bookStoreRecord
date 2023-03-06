using System;

namespace bookStoreRecord
{
    class Program
    {
        public record Bookstore(int ID, string Title, string Author, double Price)
        {
            static void Main(string[] args)
            {
                Bookstore bk1 = new(1, "The Power of Myth", "Joseph Campbell", 11.99);
                Bookstore bk2 = new(2, "Heart of Darkness", "Joseph Conrad", 10.99);
                Bookstore bk3 = new(3, "The Implied Spider", "Wendy Doniger", 12.99);

                Console.WriteLine(bk1);
                Console.WriteLine(bk2);
                Console.WriteLine(bk3);
            }
        }
    }
}