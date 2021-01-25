using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;

namespace BankBills.Model
{
  public sealed class BillsRepository : Repository<Bills>
  {
    public new static void Insert(Bills bills)
    {
      string connection = "Data Source=" + Environment.CurrentDirectory + ConfigurationManager.ConnectionStrings["SQLiteConnection"];
      using (SQLiteConnection db = new SQLiteConnection(connection))
      {
        db.Open();
        string cmd = "PRAGMA foreign_keys = ON";
        SQLiteCommand command = new SQLiteCommand(cmd, db);
        command.ExecuteNonQuery();

        cmd = "INSERT INTO 'Bills' (UserName, Account, OperationDate, Description, Amount) VALUES ('" + bills.UserName + "', '" + bills.Account + "', '" + bills.OperationDate + "', '" + bills.Description + "', '" + bills.Amount + "' )";
        command = new SQLiteCommand(cmd, db);
        command.ExecuteNonQuery();
      }
    }

    public new static void Update(Bills bills)
    {
      string connection = "Data Source=" + Environment.CurrentDirectory + ConfigurationManager.ConnectionStrings["SQLiteConnection"];
      using (SQLiteConnection db = new SQLiteConnection(connection))
      {
        db.Open();
        string cmd = "PRAGMA foreign_keys = ON";
        SQLiteCommand command = new SQLiteCommand(cmd, db);
        command.ExecuteNonQuery();

        cmd = "UPDATE 'Bills' SET UserName = '" + bills.UserName + "', Amount = '" + bills.Amount + "', OperationDate = '" + bills.OperationDate + "', Account = '" + bills.Account + "', Description = '" + bills.Description + "' WHERE Id = '" + bills.Id + "'";
        command = new SQLiteCommand(cmd, db);
        command.ExecuteNonQuery();
      }
    }

    public new static Bills Get(Bills bills)
    {
      string connection = "Data Source=" + Environment.CurrentDirectory + ConfigurationManager.ConnectionStrings["SQLiteConnection"];
      using (SQLiteConnection db = new SQLiteConnection(connection))
      {
        Bills _bills = new Bills();
        db.Open();
        string command = "SELECT Id, UserName, Account, OperationDate, Description, Amount FROM 'Bills' WHERE Id = '" + _bills.Id + "'";
        SQLiteCommand com = new SQLiteCommand(command, db);
        SQLiteDataReader r = com.ExecuteReader();
        while (r.Read())
        {
          _bills.Id = int.Parse(r["Id"].ToString());
          _bills.UserName = r["UserName"].ToString();
          _bills.Account = r["Account"].ToString();
          _bills.OperationDate = r["OperationDate"].ToString();
          _bills.Description = r["Description"].ToString();
          _bills.Amount = double.Parse(r["Amount"].ToString());
        }
        r.Close();
        return _bills;
      }
    }

    public new static IEnumerable<Bills> GetList()
    {
      string connection = "Data Source=" + Environment.CurrentDirectory + ConfigurationManager.ConnectionStrings["SQLiteConnection"];
      using (SQLiteConnection db = new SQLiteConnection(connection))
      {
        db.Open();
        List<Bills> bills = new List<Bills>();
        string command = "SELECT Id, UserName, Account, OperationDate, Description, Amount FROM 'Bills'";
        SQLiteCommand com = new SQLiteCommand(command, db);
        SQLiteDataReader r = com.ExecuteReader();
        while (r.Read())
        {
          Bills bill = new Bills()
          {
            Id = int.Parse(r["Id"].ToString()),
            UserName = r["UserName"].ToString(),
            Account = r["Account"].ToString(),
            OperationDate = r["OperationDate"].ToString(),
            Description = r["Description"].ToString(),
            Amount = double.Parse(r["Amount"].ToString())
          };
          bills.Add(bill);
        }
        r.Close();
        return bills;
      }
    }

    public new static bool IsCreated(Bills bills)
    {
      string connection = "Data Source=" + Environment.CurrentDirectory + ConfigurationManager.ConnectionStrings["SQLiteConnection"];
      using (SQLiteConnection db = new SQLiteConnection(connection))
      {
        db.Open();
        string command = "SELECT * FROM 'Bills' WHERE Id = '" + bills.Id + "'";
        SQLiteCommand com = new SQLiteCommand(command, db);
        object select = com.ExecuteScalar();
        return @select != null;
      }
    }

    public new static void Delete(Bills bills)
    {
      string connection = "Data Source=" + Environment.CurrentDirectory + ConfigurationManager.ConnectionStrings["SQLiteConnection"];
      using (SQLiteConnection db = new SQLiteConnection(connection))
      {
        db.Open();
        string cmd = "PRAGMA foreign_keys = ON";
        SQLiteCommand command = new SQLiteCommand(cmd, db);
        command.ExecuteNonQuery();

        cmd = "DELETE FROM 'Bills' WHERE Id = '" + bills.Id + "' AND UserName = '" + bills.UserName + "' AND Amount = '" + bills.Amount + "' AND OperationDate = '" + bills.OperationDate + "' AND Account = '" + bills.Account + "' AND Description = '" + bills.Description + "'";
        command = new SQLiteCommand(cmd, db);
        command.ExecuteNonQuery();
      }
    }
  }
}