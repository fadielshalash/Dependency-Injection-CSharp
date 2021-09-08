using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_One_Training.Moudels
{
    public class User
    {
        public int Id { set; get; }
        public string name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }

        public User(int v1, string v2, string v3, string v4, DateTime dateTime)
        {
            this.Id = v1;
            this.name = v2;
            this.Email = v3;
            this.Phone = v4;
            this.DOB = dateTime;
        }

        public User()
        {
        }
    }
}
