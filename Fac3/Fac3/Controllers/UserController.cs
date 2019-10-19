using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fac3.Factories;
using Fac3.Models;
using Fac3.Service;
using Microsoft.AspNetCore.Mvc;

namespace Fac3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        DataContextFactory<UserService> dataContextFactory = new DataContextFactory<UserService>();
        [HttpGet]
        public IActionResult GetUsers()
        {
            dataContextFactory.Instance.Insert(new User()
            {
                CreateDate = DateTime.UtcNow,
                Name = "xxa"
            });
            IEnumerable<User> users = dataContextFactory.Instance.List().ToList();
            return new JsonResult(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            User user = dataContextFactory.Instance.Get(id);
            return new JsonResult(user);
        }

        [HttpPost]
        public IActionResult PostUser(User user)
        {
            dataContextFactory.Instance.Insert(user);
            return new JsonResult(user);
        }
    }
}