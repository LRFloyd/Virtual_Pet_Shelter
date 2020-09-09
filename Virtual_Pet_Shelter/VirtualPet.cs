using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Pet_Shelter
{
    class VirtualPet
    {
        //invisable fields 

        //properties

        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        
        public bool IsHungry { get; set; }
        public bool IsThirstry { get; set; }
        public bool IsAdopted { get; set; }

        public VirtualPet()
        {
            //default constructor
        }

        public VirtualPet (string name, int age, string description)
        {
            this.Name = name;
            this.Age = age;
            this.Description = description;
        }

        public VirtualPet(string name, int age, string description, bool isHungry, bool isThirsty, bool isAdopted)
        {
            this.Name = name;
            this.Age = age;
            this.Description = description;
            this.IsAdopted = isAdopted;
            this.IsHungry = isHungry;
            this.IsThirstry = isThirsty;

        }




    }
}
