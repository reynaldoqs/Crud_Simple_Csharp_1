using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudApp.Models;
using CrudApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private UsersRP RepoUsers = new UsersRP();
        // GET: api/Users
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return RepoUsers.getUsers();
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "Get")]
        public User Get(int id)
        {
            return RepoUsers.getUser(id);
        }

        // POST: api/Users
        [HttpPost]
        public IActionResult Post(User value)
        {
            RepoUsers.addUser(value);
            return CreatedAtAction(nameof(Post), value);
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User value)
        {
            RepoUsers.updateUser(id, value);
            return NoContent();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            RepoUsers.removeUser(id);
            return NoContent();
        }
    }
}
