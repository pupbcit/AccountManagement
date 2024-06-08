using AccountManagementData;
using AccountManagementModels;

namespace AccountManagementServices
{
    public class UserGetServices
    {
        private List<User> GetAllUsers()
        {
            UserData userData = new UserData();

            return userData.GetUsers();

        }

        public List<User> GetUsersByStatus(int userStatus)
        {
            List<User> usersByStatus = new List<User>();

            foreach (var user in GetAllUsers())
            {
                if (user.status == userStatus)
                {
                    usersByStatus.Add(user);
                }
            }

            return usersByStatus;
        }

        public User GetUser(string username, string password)
        {
            User foundUser = new User();

            foreach (var user in GetAllUsers())
            {
                if (user.username == username && user.password == password)
                {
                    foundUser = user;
                }
            }

            return foundUser;
        }

        public User GetUser(string username)
        {
            User foundUser = new User();

            foreach (var user in GetAllUsers())
            {
                if (user.username == username)
                {
                    foundUser = user;
                }
            }

            return foundUser;
        }
    }
}