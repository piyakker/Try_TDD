using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() =>
            new List<User>()
            {
                new User()
                    {
                        Id = 1,
                        Name = "Test1",
                        Email = "test1@example.com",
                        Address = new Address
                        {
                            Street = "123 Main St",
                            City = "Madison",
                            ZipCode = "53704"
                        }
                    },
                new User()
                    {
                        Id = 2,
                        Name = "Test2",
                        Email = "test2@example.com",
                        Address = new Address
                        {
                            Street = "123 Main St",
                            City = "Madison",
                            ZipCode = "53704"
                        }
                    },
                new User()
                    {
                        Id = 3,
                        Name = "Test3",
                        Email = "test@example.com",
                        Address = new Address
                        {
                            Street = "123 Main St",
                            City = "Madison",
                            ZipCode = "53704"
                        }
                    }
            };
    }
}
