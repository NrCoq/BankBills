using System.Collections.Generic;
using System.Linq;

namespace BankBills.Model
{
  public sealed class Users : IEntity
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string[,] ToArray()
    {
      IEnumerable<Users> users = UsersRepository.GetList();
      string[,] array = new string[users.Count(), 2];
      int i = 0;
      foreach (Users user in users)
      {
        array[i, 0] = user.Id.ToString();
        array[i, 1] = user.Name.ToString();
        i++;
      }
      return array;
    }

    public override string ToString()
    {
      return "Id: " + Id + ", Name: " + Name + ".";
    }
  }
}
