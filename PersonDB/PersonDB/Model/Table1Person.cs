using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonDB.Model
{
    [Table("Table_1_Person")]
    public partial class Table1Person
    {
        public Table1Person()
        {
            Table2Phone = new HashSet<Table2Phone>();
        }

        public Table1Person(string name, short? age)
        {
            Name = name;
            Age = age;
        }

        public Table1Person(string name, short? age, ICollection<Table2Phone> table2Phone)
        {
            Name = name;
            Age = age;
            Table2Phone = table2Phone;
        }

        public long Id { get; set; }
        [Column(TypeName = "nchar(10)")]
        public string Name { get; set; }
        public short? Age { get; set; }

        [InverseProperty("Person")]
        public ICollection<Table2Phone> Table2Phone { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Age}";
        }
    }
}
