using CloudCustomers.API.Config;
using CloudCustomers.API.Models;
using CloudCustomers.API.Services.Interface;
using Microsoft.Extensions.Options;

namespace CloudCustomers.API.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;
        private readonly UsersApiOptions _apiConfig;
        public UserService(HttpClient httpClient, IOptions<UsersApiOptions> apiConfig)
        {
            _httpClient = httpClient;
            _apiConfig = apiConfig.Value;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var userResponse = await _httpClient
                .GetAsync(_apiConfig.EndPoint);

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
