using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CoinCombinations.Models;
using System;

namespace CoinCombinations.Tests
{
  [TestClass]
  public class CoinCombinationsTest
  {
    [TestMethod]
    public void CheckDatMoney_ReturnNumberOfPenniesRequired_Int()
    {
      //Arrange
      CashMoney testCash = new CashMoney(78);
      int expected = 78;
      //Act
      int actual = testCash.GetPennies();
      //Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CheckDatMoney_ReturnNumberOfNickelsRequired_Int()
    {
      //Arrange
      CashMoney testCash = new CashMoney(78);
      int expected = 15;
      //Act
      int actual = testCash.GetNickels();
      //Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CheckDatMoney_ReturnMinimumNumberOfCoins_Dictionary()
    {
      //Arrange
      CashMoney testCash = new CashMoney(92);
      Dictionary<string, int> expected = new Dictionary<string, int> ()
      {
        {"Quarters", 3},
        {"Dimes", 1},
        {"Nickels", 1},
        {"Pennies", 2}
      };
      //Act
      Dictionary<string, int> actual = testCash.CheckDatMoney();
      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }
  }
}
