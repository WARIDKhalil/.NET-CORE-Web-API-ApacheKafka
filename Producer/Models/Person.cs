using System;

namespace Producer.Models
{
    public class Person
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }

        public Person() { }
    }
}
