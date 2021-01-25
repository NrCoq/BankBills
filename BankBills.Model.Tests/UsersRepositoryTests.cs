using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankBills.Model.Tests
{
  [TestClass]
  public class UsersRepositoryTests
  {
    private Users _users;

    [TestInitialize]
    public void TestInitialize()
    {
      _users = new Users()
      {
        Id = 123,
        Name = "Oleg"
      };
      if (UsersRepository.IsCreated(_users))
      {
        UsersRepository.Update(_users);
      }
      else
      {
        UsersRepository.Insert(_users);
      }
    }

    [TestMethod]
    public void Add()
    {
      bool actual = UsersRepository.IsCreated(_users);
      UsersRepository.Delete(_users);

      Assert.AreEqual(true, actual);
    }

    [TestMethod]
    public void Update()
    {
      string expected = "Oleg";

      _users.Name = "Oleg";
      UsersRepository.Update(_users);
      Users Users = UsersRepository.Get(_users);
      string actual = Users.Name;
      UsersRepository.Delete(_users);

      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Get()
    {
      int expectedId = 123;
      string expectedName = "Oleg";

      Users Users = UsersRepository.Get(_users);
      int actualId = Users.Id;
      string actualName = Users.Name;

      Assert.AreEqual(expectedId, actualId);
      Assert.AreEqual(expectedName, actualName);
    }

    [TestMethod]
    public void Delete()
    {
      UsersRepository.Delete(_users);
      bool actual = UsersRepository.IsCreated(_users);

      Assert.AreEqual(false, actual);
    }
  }
}
