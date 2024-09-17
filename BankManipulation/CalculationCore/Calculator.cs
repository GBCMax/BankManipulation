using BankManipulation.Interfaces;
using BankManipulation.Models;

namespace BankManipulation.CalculationCore
{
  public abstract class Calculator : ICalculator
  {
    public virtual void CalculateInterest(Account account)
    {

    }
  }
}
