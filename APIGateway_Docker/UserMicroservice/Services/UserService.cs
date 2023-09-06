using UserMicroservice.Data;
using UserMicroservice.Model;
using UserMicroservice.Services.Interface;

namespace UserMicroservice.Services
{
    public class UserService : IUserService
    {
        public IEnumerable<User> GetUserList()
        {
            return StaticUserData.Users;
        }

        public User GetUserById(int id)
        {
            return StaticUserData.Users.FirstOrDefault(x => x.Id == id);
        }

        public User AddUser(User user)
        {
            // Add your logic to add a new product to the static data
            return user;
        }

        public User UpdateUser(User user)
        {
            // Add your logic to update a product in the static data
            return user;
        }

        public bool DeleteUser(int Id)
        {
            // Add your logic to delete a product from the static data
            return false; // Return appropriate result
        }
    }
}