using DesafioAMcom.Domain;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;

namespace DesafioAMcom.Infrastructure
{
    public class HttpUsersRepository
    {
        private readonly HttpClient _httpClient;
        public HttpUsersRepository(HttpClient httpClient) => _httpClient = httpClient;

        public async Task<IEnumerable<User>> FetchUsers(string? name, string? email)
        {
            var response = await _httpClient.GetFromJsonAsync<ApiResponse>("https://reqres.in/api/users?page=2");
            var users = response?.Data ?? new List<User>();

            if (!string.IsNullOrEmpty(name))
                users = users.Where(u => u.FirstName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!string.IsNullOrEmpty(email))
                users = users.Where(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase)).ToList();

            return users;
        }

        public class ApiResponse
        {
            public List<User> Data { get; set; } = new();
        }
    }
}
