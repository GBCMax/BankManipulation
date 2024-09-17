using BankManipulation.CalculationCore;
using BankManipulation.Models;

internal class Program
{
  private static void Main(string[] args)
  {
    var account1 = new Account() { Type = "Обычный", Balance = 500, Interest = 10 };

    Console.WriteLine($"Создан {account1.Type} аккаунт");

    Calculator calculator = new SimpleCalculator();

    Console.WriteLine($"Расчет процентной ставки...");

    calculator.CalculateInterest(account1);

    Console.WriteLine($"Ваша процентная ставка: {account1.Interest}");

    var account2 = new Account() { Type = "Зарплатный", Balance = 20000, Interest = 15 };

    Console.WriteLine($"Создан {account2.Type} аккаунт");

    calculator = new PayrollCalculator();

    Console.WriteLine($"Расчет процентной ставки...");

    calculator.CalculateInterest(account2);

    Console.WriteLine($"Ваша процентная ставка: {account2.Interest}");
  }
}