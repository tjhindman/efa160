
    public class Cat : Animal
    {
        public Cat()
        {
            System.Console.WriteLine("This is the Cat constructor.");
            IsMammal = true;
            DietType = DietType.Carnivore;
        }

        //properties
        public double ClawLength { get; set; }

        //we can have our own virtual method for this cat class...
        public virtual void MakeSound()
        {
            System.Console.WriteLine("Meow.");
        }

        //ok, at this point I want the cat to have its own movement
        public override void Move()
        {
            //ok, lets keep our parents movement 'action' 
           // base.Move();

            System.Console.WriteLine($"The {GetType().Name} moves quickly!");
        }
    }

    public class TabbyCat: Cat
    {
        public TabbyCat()
        {
            System.Console.WriteLine("This is the TabbyCat Constructor.");
        }
        //override of MakeSound()
        public override void MakeSound()
        {
            System.Console.WriteLine("Purr...");
        }
    }