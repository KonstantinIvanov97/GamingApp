using GamingApp.Data.Models;

namespace GamingApp.Services.Interfaces
{
    public interface IUserService
    {
        User Register(string username, string password);

        User Login(string username, string password);
    }
}
