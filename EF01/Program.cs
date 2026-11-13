
using EF01.Data;
using Microsoft.EntityFrameworkCore;

namespace EF01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (BookStoreDbContext context = new BookStoreDbContext())
            {
                bool created = context.Database.EnsureCreated();

                if (created)
                {
                    Console.WriteLine("Database Created Successfully!");
                }
                else
                {
                    Console.WriteLine("Database Already Exists!");
                }

                Console.WriteLine("Database Name: " +
                    context.Database.GetDbConnection().Database);
            }

            Console.ReadKey();
        }
    }
}
