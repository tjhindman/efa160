//Properties 

// These give the developer the  ability to read and write to a specific piece of date (or private field) 

// These live in an object (class)
// They Read , Write, and Compute

// public Type variableName {get; set;}

// These are short hand for Read/Write Methods

//Pascal case EveryFirstLetterWordIsCapitalized


Donut doug = new Donut();
doug.Filling = "Strawberry Jam";
System.Console.WriteLine(doug.GetDonutType());

//testing some other properties
doug.Topping = "Sprinkles";
doug.IsSpecial = false;
doug.Price = 1.98m;

System.Console.WriteLine(doug.ToString());
System.Console.WriteLine("-- Implicit ToString() below--");
System.Console.WriteLine(doug);

Donut doug2 = new Donut("Yuck", "Even more gross", "Probably the best part", true);
System.Console.WriteLine(doug2);



// this is for setup:
class Donut
{
    #region Private backing Field
    private string _donutType;
    //private string _Filling;

    #endregion

    #region Propertes...Attributes
    public string Filling { get; set; }
    //public string Filling
    //{
    //    get
    //    {
    //        read only
    //        we can actually do computation here...
    //        return _Filling.ToUpper();
    //    }
    //    set
    //    {
    //        _Filling=value;
    //    }
    //}
    public string Topping { get; set; }
    public decimal Price { get; set; } = .25m;
    public bool IsSpecial { get; set; } = false;
    #endregion

    #region Constructors. what we use to make the object (class) on the fly
    //todo: We are making overloads

    //this is our default one.
    public Donut()
    {
        _donutType = "Plain Jane";
    }

    //overload two
    public Donut(string donutType)
    {
        _donutType = donutType;
    }

    //overload three
    public Donut(string donutType, string filling, string topping, bool IsSpecial)
    {
        _donutType = donutType;
        Filling = filling;
        Topping = topping;
        this.IsSpecial = IsSpecial;
    }

    #endregion

    #region Get/Set Methods this is how we will retrive the private data via out Private Backing Field

    public string GetDonutType()
    {
        return _donutType;
    }

    public void SetDonutType(string donutType)
    {
        _donutType = donutType;
    }

    #endregion

    #region Special Price Calculation
    private decimal CalculateSpecialPrice(bool isSpecial)
    {
        if (isSpecial)
        {
            return Price *= 2;
        }
        else
        {
            return Price;
        }
    }
    #endregion

    #region overriding ToString()
    //Every Class has a ToString()
    public override string ToString()
    {
        return $"This donut is {this.GetDonutType()}\n full of {this.Filling}\n and topped with {this.Topping}\n for {CalculateSpecialPrice(this.IsSpecial)}";
    }
    #endregion
}
