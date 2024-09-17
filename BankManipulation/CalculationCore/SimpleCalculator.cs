using BankManipulation.Models;

namespace BankManipulation.CalculationCore
{
  public class SimpleCalculator : Calculator
  {
    public override void CalculateInterest(Account account)
    {
      account.Interest = account.Balance * 0.4;

      if (account.Balance < 1000)
        account.Interest -= account.Balance * 0.2;

      if (account.Balance >= 1000)
        account.Interest -= account.Balance * 0.4;
    }
  }
}
