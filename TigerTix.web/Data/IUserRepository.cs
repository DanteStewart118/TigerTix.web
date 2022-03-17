using System.Collections.Generic;
using TigerTix.web.Data.Entities;

namespace TigerTix.web.Data
{
    public interface IUserRepository
    {
        void DeleteUser(User user);
        IEnumerable<User> GetAllUsers();
        User GetUsersByID(int userID);
        bool SaveAll();
        void SaveUser(User user);
        void UpdateUser(User user);
    }
}