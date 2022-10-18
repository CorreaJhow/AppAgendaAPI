using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace ExemploAPI.Model
{
    public class Adress
    {
        [Key()]
        public int Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        [ForeignKey("Person")]
        public int IdPerson { get; set; }
        public Person Person { get; set; }
    }
}
