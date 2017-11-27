using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Core.Interfaces;
using System.Web.Script.Serialization;
using Core;

namespace Service.Controllers
{
    public class UserController : ApiController
    {
        private IUserRepository RepoUsers;

        public UserController(IUserRepository RepoUser)
        {
            this.RepoUsers = RepoUser;
        }

        public UserController()
        {
            this.RepoUsers = UserRepository.Instance;
        }

        // GET: api/User
        public IEnumerable<User> Get()
        {
            return RepoUsers.GetAllUsers();
        }

        // GET: api/User/5
        public string Get(string Username)
        {
            return "value";
        }

        // POST: api/User
        public void Post([FromBody]User dummyFour)
        {
            throw new NotImplementedException();
        }
        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        public void Delete([FromBody]User dummyOne)
        {
            throw new NotImplementedException();
        }
    }
}
