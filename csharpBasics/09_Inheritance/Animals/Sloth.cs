
    public class Sloth : Animal
    {
        public Sloth()
        {
            System.Console.WriteLine("Sloth Constructor");
        }

        //Read only Property:
        public bool IsSlow
        {
            get
            {
                return true;
            }
        }

        public override void Move()
        {
            System.Console.WriteLine("The Sloth moves slowly...");
        }
    }

    public class Megatherium : Sloth
    {
        public Megatherium()
        {
            System.Console.WriteLine("This sloth is extinct.");
        }

        public  override void Move()
        {
            System.Console.WriteLine("Megatherium uses move! Its not Super Effective....");
        }
    }
