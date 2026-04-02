namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Take_A_Logger_In_The_Constructor_And_Call_The_Log_Method_On_Logger_As_A_Private_Class_Level_Field_Instead_Of_As_Its_Parent(){
       var logger = new Logger();
       var shoppingCart = new ShoppingCart(logger);

        Assert.False(shoppingCart is Logger);

        shoppingCart.AddItem("test");

        Assert.Equal(1, logger.Messages.Count);
        Assert.Equal("Added item 'test' to cart", logger.Messages[0]);
    }
}