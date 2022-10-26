//Inheritance
// this is our Base Class
    //this is Ground Zero 
    // we don't want the compiler to "New this up" -> no new keyword
    //use the keyword 'abstract'

//! Inheritance is an 'is a' relationship

    public abstract class Animal
    {
        public Animal()
        {
            System.Console.WriteLine("This is the Animal Constructor.");
        }

        // define some attributes 'properties'
        public int NumberOfLegs { get; set; }
        public bool  IsMammal { get; set; }
        public bool HasFur { get; set; }
        public DietType DietType { get; set; }

        //virtual keyword
        // allows us to override or give methods 'specific' behavior
        //we can make the inheriting object move however we want.
        public virtual void Move()
        {
            System.Console.WriteLine($"This {GetType().Name} moves.");
        }

    }
