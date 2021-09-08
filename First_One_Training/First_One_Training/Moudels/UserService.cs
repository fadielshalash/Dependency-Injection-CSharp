using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_One_Training.Moudels
{
    public class UserService : Iuser
    {
        public List<User> MyUsers = new List<User>
        {
            new User(1,"fadi","fadielshalash@gmail.com", " 0544883698", new DateTime(2000, 6, 30)),
            new User(2,"fadi","fadielshalash@gmail.com", " 0544883698", new DateTime(2000, 6, 30)),
            new User(3,"fadi","fadielshalash@gmail.com", " 0544883698", new DateTime(2000, 6, 30)),
            new User(4,"fadi","fadielshalash@gmail.com", " 0544883698", new DateTime(2000, 6, 30)),
            new User(5,"fadi","fadielshalash@gmail.com", " 0544883698", new DateTime(2000, 6, 30))
        };

        
        public void AddUser(User user)
        {
            MyUsers.Add(user);
        }

        
        public void DeleteUser(int id)
        {
            var filteredUsers = MyUsers.FirstOrDefault(user => user.Id.Equals(id));
            if (filteredUsers != null)
                MyUsers.Remove(filteredUsers);
        }


        
        public List<User> GetAll()
        {
            return MyUsers;
        }

       
        
        public User GetUser(int id)
        {
            return MyUsers.FirstOrDefault(user => user.Id.Equals(id));
        }
    }
}
