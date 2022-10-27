

//ctrl+ . to implement the interface (cmd for mac)
public class Banana : IFruit
{
    public Banana(){}
    public Banana(bool isPeeled)
    {
        IsPeeled = isPeeled;
    }
    #region One liner example
    // => 'returning' 
    // public string Name => throw new NotImplementedException();
    #endregion

    #region  getterExample
    /*
        Name is a getter

        public string Name
        {
            get
            {
               returns throw ....
            }
        }
    */
    #endregion
    public string Name
    {
        get
        {
            return "Banana";
        }
    }
    public bool IsPeeled { get; private set; }
    public string Peel()
    {
        IsPeeled = true;
        return "You peel the Banana.";
    }
}

public class Orange : IFruit
{
    public Orange() { }

    public Orange(bool isPeeled)
    {
        IsPeeled = isPeeled;
    }
    public string Name => "Orange";

    public bool IsPeeled { get; private set; }

    public string Peel()
    {
        IsPeeled = true;
        return "You peeled the orange.";
    }

    //we can have our own methods
    public string Squeeze()
    {
        return "You squeezed the orange, and juice comes out.";
    }
}

public class Grape : IFruit
{
    public string Name => "Grape";

    public bool IsPeeled => false;

    public string Peel()
    {
        return "Who peels Grapes.";
    }
}
