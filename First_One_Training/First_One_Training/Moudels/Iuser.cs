using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_One_Training.Moudels
{
     public interface Iuser
    {
        
        List<User> GetAll();
        User GetUser(int id);
        void DeleteUser(int id);
        void AddUser(User user);
        
    }
}
