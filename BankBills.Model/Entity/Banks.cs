using System.Collections.Generic;
using System.Linq;

namespace BankBills.Model
{
  public sealed class Banks : IEntity
  {
    public string Name { get; set; }

    public string Account { get; set; }

    public string[,] ToArray()
    {
      IEnumerable<Banks> banks = BanksRepository.GetList();
      string[,] array = new string[banks.Count(), 2];
      int i = 0;
      foreach (Banks bank in banks)
      {
        array[i, 0] = bank.Name;
        array[i, 1] = bank.Account;

        i++;
      }
      return array;
    }

    public override string ToString()
    {
      return "Name: " + Name + "Account: " + Account +  ".";
    }
  } 
}
