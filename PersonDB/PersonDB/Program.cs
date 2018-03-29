using System;
using PersonDB.Model;
using PersonDB.Repositories;

namespace PersonDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Database CRUD operations");
            //Table1Person person = new Table1Person("Anja",43);
            //PersonRepository.Create(person);

            var persons = PersonRepository.Get();
            foreach (var p in persons)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("Press <Enter> to Exit");
            Console.ReadLine();
            
        }
    }
}
