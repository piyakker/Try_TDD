using CloudCustomers.API.Models;
using CloudCustomers.API.Services.Interface;

namespace CloudCustomers.API.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;
        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var userResponse = await _httpClient.GetAsync("https://example.com");
            if (userResponse.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return new List<User> { };
            }
            
            var responseContent = userResponse.Content;
            var allUsers = await responseContent.ReadFromJsonAsync<List<User>>();
            return allUsers.ToList();
        }
    }
}
