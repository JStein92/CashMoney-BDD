using System;
using System.Collections.Generic;

namespace CoinCombinations.Models
{
  public class CashMoney
  {
    private int _initialMonies;
    private Dictionary<string, int> _myMoneyMoney = new Dictionary<string, int> ();

    public CashMoney(int coins)
    {
      _initialMonies = coins;
    }

    public Dictionary<string, int> CheckDatMoney()
    {
      int change = _initialMonies;

      int myQuarters = change/25;
      change = change%25;

      int myDimes = change/10;
      change = change%10;

      int myNickels = change/5;
      change = change%5;

      int myPennies = change;

      _myMoneyMoney.Add("Quarters", myQuarters);
      _myMoneyMoney.Add("Dimes", myDimes);
      _myMoneyMoney.Add("Nickels", myNickels);
      _myMoneyMoney.Add("Pennies", myPennies);

      return _myMoneyMoney;
    }

    public int GetPennies()
    {
      return _initialMonies;
    }

    public int GetNickels()
    {
      return (_initialMonies/5);
    }
  }
}
