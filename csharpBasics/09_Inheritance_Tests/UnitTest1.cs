using System;
using Xunit;

namespace InheritanceTest;

public class UnitTest1
{
    Cat cat;

    public UnitTest1()
    {
        cat = new Cat();
    }

    [Fact]
    public void Create_A_Cat_Should_Return_All_Info()
    {
        //AAA Setup

        //Arrange -> initial setup
        Cat cat = new Cat();
        cat.ClawLength = 44.25d;

        //Act
        double expected = cat.ClawLength;

        cat.MakeSound();
        cat.Move();

        //Assert
        Assert.Equal(expected, cat.ClawLength);

    }

    [Fact]
    public void Create_A_TabbyCat()
    {
        //Arrange
        TabbyCat cat = new TabbyCat();
        cat.NumberOfLegs = 3;
        cat.ClawLength = 2.2d;
        cat.Move();
        cat.MakeSound();

        //Act
        Type expected = cat.GetType();

        //Assertion
        Assert.Equal(expected, typeof(TabbyCat));
    }

    // public void HelperMethod()
    // {

    // }
}