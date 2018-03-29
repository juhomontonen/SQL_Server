using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonDB.Model
{
    [Table("Table_2_Phone")]
    public partial class Table2Phone
    {
        public long Id { get; set; }
        [Column(TypeName = "nchar(10)")]
        public string Type { get; set; }
        [Column(TypeName = "nchar(10)")]
        public string Number { get; set; }
        public long? PersonId { get; set; }

        [ForeignKey("PersonId")]
        [InverseProperty("Table2Phone")]
        public Table1Person Person { get; set; }
    }
}
