using System;

namespace Logbook
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string LastDate { get; set; }

        public string GetFullName() => $"{Name} {Surname} {FatherName}";
    }
}
