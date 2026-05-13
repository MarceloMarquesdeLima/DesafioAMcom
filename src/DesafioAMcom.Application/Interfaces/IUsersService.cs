using DesafioAMcom.Domain;

namespace DesafioAMcom.Application.Interfaces
{
    public interface IUsersService
    {
        Task<IEnumerable<User>> GetUsersAsync(string? name, string? email);
    }
}
