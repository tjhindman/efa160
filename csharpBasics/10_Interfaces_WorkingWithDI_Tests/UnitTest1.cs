using System.Collections.Generic;
using Xunit;

namespace Interfaces_WorkingWithDI_Tests;

public class TransactionTests
{
    private decimal _debt;
    public TransactionTests()
    {
        _debt = 9000.01m;
    }

    //Helper method to PayDebt
    private void PayDebt(ICurrency payment)
    {
        _debt-=payment.Value;
        System.Console.WriteLine($"You have paid {payment.Value:c} towards your debt.");
    }

    [Fact]
    public void PayDebtTest()
    {
        //Arrange
       PayDebt(new Dollar());
       PayDebt(new ElectronicPayment(315.52m));

        //Act
        decimal expectedAmount = 9000.01m - 316.52m; //we are accounting for the dollar subtraction above.
       System.Console.WriteLine($"expected amt: {expectedAmount:c}");
       System.Console.WriteLine($"expected _debt: {_debt:c}");
       //Assertion
       Assert.Equal(expectedAmount,_debt);
    }

    [Fact]
    public void InjectingIntoConstructors()
    {
       var dollar = new Dollar();
       var electronicPayment = new ElectronicPayment(243.71m);

       Transaction firstTransaction = new Transaction(dollar);
       Transaction secondTransaction = new Transaction(electronicPayment);

       // The Transaction object doesn't care what type is passed in its constructor
       // as long as it implements the ICurrency interface.

        System.Console.WriteLine(firstTransaction.GetTransactionType());
        System.Console.WriteLine(secondTransaction.GetTransactionType());

        //Assert
        Assert.Equal("Dollar", firstTransaction.GetTransactionType());
        Assert.Equal("Electronic Payment", secondTransaction.GetTransactionType());

    }

    [Fact]
    public void MoreExamples()
    {
        //So what if you have multiple transactions
        var list = new List<Transaction>
        {
            new Transaction(new Dollar()),
            new Transaction(new ElectronicPayment(231.95m)),
            new Transaction(new Dime()),
            new Transaction(new Dollar()),
            new Transaction(new Penny()),
        };

        //foreach loop
        //Transaction type
        // amount 
        // date

        foreach (var transaction in list)
        {
            var type = transaction.GetTransactionType();
            var amt = transaction.GetTransactionAmount();

            //write out the info
            System.Console.WriteLine($"{type} {amt:c} {transaction.DateOfTransaction}");
        }
    }
}