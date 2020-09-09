using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Pet_Shelter
{
    class Dog : VirtualPet
    {
        //fields and properties are inherent from parent(VirtualPet) class
        //properties specific to this class
        public string Type { get; set; }
        public string Diet { get; set; }

        //constructors
        public Dog()
        {
            //default constructor
        }

        //preset constructors to set type 
        public Dog(string name,string type)
        {
            this.Name = name;
            this.Diet = "meat";
            this.Type = type;
        }

        //preset constructor with set status bools
        public Dog(string name, string description, int age) : base(false, false, false)
        {
            this.Name = name;
            this.Age = age;
            this.Description = description;
        }
    }
}
