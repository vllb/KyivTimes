using KyivTimes.Data.Models;
using System.Data.SqlTypes;

namespace KyivTimes.Data.Repositories
{
    public class UserRepo : IUserRepo
    {
        private KyivTimesDbContext _context;
        public UserRepo(KyivTimesDbContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = GetUser(id);
            if(user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }

        }

        public User GetUser(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}
