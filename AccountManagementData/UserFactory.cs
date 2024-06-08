using AccountManagementModels;

namespace AccountManagementData
{
    public class UserFactory
    {
        private List<User> dummyUsers = new List<User>();

        public List<User> GetDummyUsers()
        {
            dummyUsers.Add(CreateDummyUser("Admin123!", "Admin", "Admin@pup.com"));
            dummyUsers.Add(CreateDummyUser("Test123!", "Test", "Test@pup.com"));
            dummyUsers.Add(CreateDummyUser("Hello123!", "Hello", "Hello@pup.com"));
            dummyUsers.Add(CreateDummyUser("Bye123!", "Bye", "Bye@pup.com"));

            return dummyUsers;
        }

        private User CreateDummyUser(string password, string username, string emailaddress)
        {
            User user = new User
            {
                username = username,
                password = password,
                profile = new UserProfile { emailAddress = emailaddress, profileName = username },
                dateUpdated = DateTime.Now,
                dateVerified = DateTime.Now.AddDays(1),
                status = 1
            };

            return user;
        }

    }
}
