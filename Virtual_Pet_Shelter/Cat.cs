using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Pet_Shelter
{
    class Cat : VirtualPet
    {
        //fields and properties are inherent from parent(VirtualPet) class
        //properties specific to this class
        public string Type { get; set; }
        public string Diet { get; set; }

        //constructors
        public Cat()
        {
            //default constructor
        }

        //preset constructors to set type 
        public Cat(string name)
        {
            this.Name = name;
            this.Diet = "vegitarian";
            this.Type = "Persian";
        }

        public Cat(string name, string description, int age) : base(false,false,false)
        {
            this.Name = name;
            this.Age = age;
            this.Description = description;
        }
    }
}
