using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookShopAPI.Models;
using static DataLibrary.BusinessLogic.UserProcessor;

namespace BookShopAPI.Controllers
{
    public class UserController : ApiController
    {
        List<UserModel> users = new List<UserModel>();
        public UserController()
        {
            var data = LoadUsers();
            foreach (var row in data)
            {
                users.Add(new UserModel
                {
                    Id = row.Id,
                    Name = row.Name,
                    Title = row.Title,
                    Author = row.Author,
                    Review = row.Review
                });
            }
        }
        // GET: api/User
        public List<UserModel> Get()
        {
            return users;
        }

        // GET: api/User/5
        public UserModel Get(int id)
        {
            return users.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/User
        public void Post(UserModel val)
        {
            users.Add(val);
        }

 

        // DELETE: api/User/5
        public void Delete(int id)
        {
           users.Remove(users.Where(x => x.Id == id).FirstOrDefault());
        }
    }
}
