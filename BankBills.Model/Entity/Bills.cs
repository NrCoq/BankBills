using System.Collections.Generic;
using System.Linq;

namespace BankBills.Model
{
  public sealed class Bills : IEntity
  {
    public int Id { get; set; }

    public string UserName { get; set; }

    public string Account { get; set; }

    public string OperationDate { get; set; }

    public string Description { get; set; }

    public double Amount { get; set; }

    public string[,] ToArray()
    {
      IEnumerable<Bills> bills = BillsRepository.GetList();
      string[,] array = new string[bills.Count(), 6];
      int i = 0;
      foreach (Bills bill in bills)
      {
        array[i, 0] = bill.Id.ToString();
        array[i, 1] = bill.UserName;
        array[i, 2] = bill.Account;
        array[i, 3] = bill.OperationDate;
        array[i, 4] = bill.Description;
        array[i, 5] = bill.Amount.ToString();
        

        
        i++;
      }
      return array;
    }

    public override string ToString()
    {
      return "Id: " + Id + ", UserName: " + UserName + "Account: " + Account + ", OperationDate: " + OperationDate + ",Description: " + Description + ", Amount: " + Amount + ".";
    }
  }
}