namespace AccountManagementModels
{
    public class User
    {
        public string username;
        public string password;
        public DateTime dateVerified;
        private DateTime dateCreated = DateTime.Now;
        public DateTime dateUpdated;
        public UserProfile profile;
        public int status; 
    }
}