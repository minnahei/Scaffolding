using System;
namespace Personas.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Dni Dni { get; set; }
        public DateTime fechaNacimiento { get; set; }
    }
}
