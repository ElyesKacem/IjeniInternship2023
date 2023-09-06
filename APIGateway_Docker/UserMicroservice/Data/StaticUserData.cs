using UserMicroservice.Model;
using System.Collections.Generic;

namespace UserMicroservice.Data
{
    public class StaticUserData
    {
        public static List<User> Users { get; } = new List<User>
        {
            new User
            {
                Id = 1,
                UserName = "ayet",
                Address = "ayetayadi01@gmail.com"
            }
        };
    }
}
