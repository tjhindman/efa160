using System.Collections.Generic;
using Xunit;

namespace InterfaceTests;

public class UnitTest1
{
    [Fact]
    public void Calling_Interface_Methods()
    {
        //declare a new interface instance
        // its Type will be IFruit
        // We cannot new-up interfaces
        // but we can make a new banana
        IFruit banana= new Banana();

        string output = banana.Peel();
        System.Console.WriteLine(output);

        System.Console.WriteLine("The banana is peeled: "+ banana.IsPeeled);

        Assert.True(banana.IsPeeled);

    }

    [Fact]
    public void Interface_Collections()
    {
        //start with orange object
        // its not going to be an IFruit

        Orange orange = new Orange();

        //lets make a list
        List<IFruit> fruits = new List<IFruit>
        {
            new Banana(),
            new Grape(),
            orange
        };

        //loop through this list
        foreach (IFruit fruit in fruits)
        {
            System.Console.WriteLine(fruit.Name);
            System.Console.WriteLine(fruit.Peel());

            Assert.Equal(typeof(IFruit).Name,fruit.GetType().GetInterface("IFruit").Name);
        }

        System.Console.WriteLine(orange.Squeeze());

       
    }

    private string GetFruitName(IFruit fruit)
    {
        return $"This fruit is called: {fruit.Name}.";
    }

    [Fact]
    public void Interface_In_Methods()
    {
        var grape = new Grape();

        //this will work b/c Grape(class) implements IFuit
        var output = GetFruitName(grape);

        System.Console.WriteLine(output);

        Assert.True(output.Contains("This fruit is called: Grape."));
    }

    [Fact]
    public void Type_Of_Instance()
    {
        var fruitSalad = new List<IFruit>
        {
            new Orange(true),
            new Orange(),
            new Grape(),
            new Orange(),
            new Banana(true),
            new Grape()
        };

        System.Console.WriteLine("Is the orange Peeled?");
        foreach (var fruit in fruitSalad)
        {
            //the 'is' keyword will allow to cast 
            if(fruit is Orange orange)
            {
                if(orange.IsPeeled)
                {
                    System.Console.WriteLine("Is a peeled orange.");
                }
                else
                {
                    System.Console.WriteLine("Is an orange.");
                }
            }
            else if(fruit.GetType() == typeof(Grape))
            {
                System.Console.WriteLine("Is a Grape.");
            }
            else if(fruit.IsPeeled)
            {
                System.Console.WriteLine("You peeled the Banana.");
            }
            else
            {
                System.Console.WriteLine("Its a Banana!");
            }

        }
    }
}

// Pattern Matching
    // Another way to demonstrate checking types is with Pattern Matching
    // Docs: https://docs.microsoft.com/en-us/dotnet/csharp/pattern-matching
    // This is basically the same way we did the first if (fruit is Orange orange)