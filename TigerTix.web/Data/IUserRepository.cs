using System.Collections.Generic;
using TigerTix.web.Data.Entities;

namespace TigerTix.web.Data
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUsersByID(int userID);
        void DeleteUser(User user);
        void SaveUser(User user);
        void UpdateUser(User user);
        bool SaveAll();
    }
}