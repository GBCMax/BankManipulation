using BankManipulation.Models;

namespace BankManipulation.CalculationCore
{
  public class PayrollCalculator : Calculator
  {
    public override void CalculateInterest(Account account)
    {
      account.Interest = account.Balance * 0.5;
    }
  }
}