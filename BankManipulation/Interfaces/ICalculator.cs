using BankManipulation.Models;

namespace BankManipulation.Interfaces
{
  public interface ICalculator
  {
    void CalculateInterest(Account account);
  }
}
