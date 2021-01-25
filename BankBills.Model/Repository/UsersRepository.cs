using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;

namespace BankBills.Model
{
  public sealed class UsersRepository : Repository<Users>
  {
    public new static void Insert(Users users)
    {
      string connection = "Data Source=" + Environment.CurrentDirectory + ConfigurationManager.ConnectionStrings["SQLiteConnection"];
      using (SQLiteConnection db = new SQLiteConnection(connection))
      {
        db.Open();
        string cmd = "PRAGMA foreign_keys = ON";
        SQLiteCommand command = new SQLiteCommand(cmd, db);
        command.ExecuteNonQuery();

        cmd = "INSERT INTO 'Users' (Name) VALUES ('" + users.Name + "')";
        command = new SQLiteCommand(cmd, db);
        command.ExecuteNonQuery();
      }
    }

    public new static void Update(Users users)
    {
      string connection = "Data Source=" + Environment.CurrentDirectory + ConfigurationManager.ConnectionStrings["SQLiteConnection"];
      using (SQLiteConnection db = new SQLiteConnection(connection))
      {
        db.Open();
        string cmd = "PRAGMA foreign_keys = ON";
        SQLiteCommand command = new SQLiteCommand(cmd, db);
        command.ExecuteNonQuery();

        cmd = "UPDATE 'Users' SET Name = '" + users.Name + "' WHERE Id = '" + users.Id + "'";
        command = new SQLiteCommand(cmd, db);
        command.ExecuteNonQuery();
      }
    }

    public new static Users Get(Users users)
    {
      string connection = "Data Source=" + Environment.CurrentDirectory + ConfigurationManager.ConnectionStrings["SQLiteConnection"];
      using (SQLiteConnection db = new SQLiteConnection(connection))
      {
        Users _users = new Users();
        db.Open();
        string command = "SELECT Id, Name FROM 'Users' WHERE Id = '" + users.Id + "'";
        SQLiteCommand com = new SQLiteCommand(command, db);
        SQLiteDataReader r = com.ExecuteReader();
        while (r.Read())
        {
          _users.Id = int.Parse(r["Id"].ToString());
          _users.Name = r["Name"].ToString();
        }
        r.Close();
        return _users;
      }
    }

    public new static IEnumerable<Users> GetList()
    {
      string connection = "Data Source=" + Environment.CurrentDirectory + ConfigurationManager.ConnectionStrings["SQLiteConnection"];
      using (SQLiteConnection db = new SQLiteConnection(connection))
      {
        db.Open();
        List<Users> users = new List<Users>();
        string command = "SELECT Id, Name FROM 'Users'";
        SQLiteCommand com = new SQLiteCommand(command, db);
        SQLiteDataReader r = com.ExecuteReader();
        while (r.Read())
        {
          Users user = new Users()
          {
            Id = int.Parse(r["Id"].ToString()),
            Name = r["Name"].ToString()
          };
          users.Add(user);
        }
        r.Close();
        return users;
      }
    }

    public new static bool IsCreated(Users users)
    {
      string connection = "Data Source=" + Environment.CurrentDirectory + ConfigurationManager.ConnectionStrings["SQLiteConnection"];
      using (SQLiteConnection db = new SQLiteConnection(connection))
      {
        db.Open();
        string command = "SELECT * FROM 'Users' WHERE Id = '" + users.Id + "'";
        SQLiteCommand com = new SQLiteCommand(command, db);
        object select = com.ExecuteScalar();
        return @select != null;
      }
    }

    public new static void Delete(Users users)
    {
      string connection = "Data Source=" + Environment.CurrentDirectory + ConfigurationManager.ConnectionStrings["SQLiteConnection"];
      using (SQLiteConnection db = new SQLiteConnection(connection))
      {
        db.Open();
        string cmd = "PRAGMA foreign_keys = ON";
        SQLiteCommand command = new SQLiteCommand(cmd, db);
        command.ExecuteNonQuery();

        cmd = "DELETE FROM 'Users' WHERE Id = '" + users.Id + "' AND Name = '" + users.Name + "'";
        command = new SQLiteCommand(cmd, db);
        command.ExecuteNonQuery();
      }
    }
  }
}