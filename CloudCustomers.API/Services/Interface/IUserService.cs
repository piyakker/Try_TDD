using CloudCustomers.API.Models;

namespace CloudCustomers.API.Services.Interface
{
    public interface IUserService
    {
        public Task<List<User>> GetAllUsers();
    }
}
