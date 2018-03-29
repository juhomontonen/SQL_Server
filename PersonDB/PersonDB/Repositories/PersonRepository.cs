using System;
using System.Collections.Generic;
using System.Text;
using PersonDB.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PersonDB.Repositories
{
    class PersonRepository
    {
        private static Tuntitehtava2Context _context = new Tuntitehtava2Context();

        public static void Create(Table1Person person)
        {
            _context.Table1Person.Add(person);
            _context.SaveChanges();
        }

        public static List<Table1Person> Get()
        {
            List<Table1Person> persons = _context.Table1Person.ToListAsync().Result;
            return persons; 
        }

        public static Table1Person GetpersonById(int id)
        {
            var person = _context.Table1Person.FirstOrDefault(p => p.Id == id);
            return person;
        }

    }
}
