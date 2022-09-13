using KyivTimes.Data.Models;

namespace KyivTimes.Data.Repositories
{
    public interface IUserRepo
    {
        void AddUser(User user);
        User GetUser(int id);
        void DeleteUser(int id);
    }
}
