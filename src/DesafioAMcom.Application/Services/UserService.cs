using DesafioAMcom.Application.Interfaces;
using DesafioAMcom.Domain;
using DesafioAMcom.Infrastructure;

namespace DesafioAMcom.Application.Services
{
    public class UsersService : IUsersService
    {
        private readonly HttpUsersRepository _repo;
        public UsersService(HttpUsersRepository repo) => _repo = repo;
        public Task<IEnumerable<User>> GetUsersAsync(string? name, string? email) => _repo.FetchUsers(name, email);
    }
}
