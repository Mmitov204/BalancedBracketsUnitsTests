using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class BalancedBracketsTests
{
    [Test]
    public void Test_IsBalanced_EmptyInput_ShouldReturnTrue()
    {
        //Arrange
        string[] EmptyInput = new string[] { };
        //Act
        bool result = BalancedBrackets.IsBalanced(EmptyInput);
        //Assert
        Assert.IsTrue(result);

    }

    [Test]
    public void Test_IsBalanced_BalancedBrackets_ShouldReturnTrue()
    {
        //Arrange
        string[] Input = new string[] { "(", ")", "(", ")" };
        //Act
        bool result = BalancedBrackets.IsBalanced(Input);
        //Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsBalanced_UnbalancedBrackets_ShouldReturnFalse()
    {
        //Arrange
        string[] UnbalancedInput = new string[] { "(", ")", ")", ")" };
        //Act
        bool result = BalancedBrackets.IsBalanced(UnbalancedInput);
        //Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsBalanced_MoreClosingBrackets_ShouldReturnFalse()
    {
        //Arrange
        string[] UnbalancedInput = new string[] { "(", ")", ")", ")",")" };
        //Act
        bool result = BalancedBrackets.IsBalanced(UnbalancedInput);
        //Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsBalanced_NoClosingBrackets_ShouldReturnFalse()
    {
        //Arrange
        string[] UnbalancedInput = new string[] { "(", "(", "(", "(", "(" };
        //Act
        bool result = BalancedBrackets.IsBalanced(UnbalancedInput);
        //Assert
        Assert.IsFalse(result);
    }
}
