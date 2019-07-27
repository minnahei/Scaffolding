using System;
namespace Personas.Models
{
    public class Dni
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
