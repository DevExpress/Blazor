using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.RazorComponents.Model
{
    public enum Department { Motors, Electronics, Software }
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }

        public string Text => $"{FirstName} {LastName} ({Department} Dept.)";
    }
}