using CloudCustomers.API.Models;
using CloudCustomers.API.Services.Interface;

namespace CloudCustomers.API.Services
{
    public class UserService : IUserService
    {
        public UserService() { }

        public Task<List<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
