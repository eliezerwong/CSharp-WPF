using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public class Puppy
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Breed { get; set; }

        public Puppy()
        {
            Name = string.Empty;
            DateOfBirth = DateTime.Now;
            Breed = string.Empty;
        }

        public Puppy(string name, string breed)
        {
            Name = name;
            //DateOfBirth = DateTime.Today;
            Breed = breed;
        }

        public override string ToString()
        {
            return $"{Breed} - {Name}"; 
        }
    }
}
