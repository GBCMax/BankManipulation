namespace BankManipulation.Models;
public class Account
{
  public string Type { get; set; } = string.Empty;
  public double Balance { get; set; }
  public double Interest { get; set; }
}