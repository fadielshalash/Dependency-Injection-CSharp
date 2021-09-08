using First_One_Training.Moudels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_One_Training.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        Iuser users = null;

        public UserController(Iuser myus)
        {
            users = myus;
        }

        [HttpGet]
        public List<User> Get()
        {
            return users.GetAll();
        }

        [HttpGet("{id}")]
        public User GetUser(int id)
        {
            return users.GetUser(id);
        }

        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            users.DeleteUser(id);
        }

        [HttpPost]
        public void AddUser([FromBody]User user)
        {
            users.AddUser(user);
        }

    }
}
