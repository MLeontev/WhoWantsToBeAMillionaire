using WhoWantsToBeAMillionaire.Models;

namespace WhoWantsToBeAMillionaire.Services
{
    public class UsersService
    {
        private MillionaireDBContext context;

        public UsersService()
        {
            this.context = ContextProvider.GetDbContext();
        }

        public User CreateUser(string name)
        {
            User newUser = new User
            {
                Name = name
            };

            context.Users.Add(newUser);
            context.SaveChanges();

            return newUser;
        }

        public void UpdateUser(User user, int result)
        {
            user.Result = result;
            context.SaveChanges();
        }

        public List<User> GetTop()
        {
            var top = context.Users.OrderByDescending(u => u.Result).Take(10).ToList();
            return top;
        }

        public void DeleteUsers()
        {
            List<User> users = context.Users.ToList();
            context.Users.RemoveRange(users);
            context.SaveChanges();
        }
    }
}
