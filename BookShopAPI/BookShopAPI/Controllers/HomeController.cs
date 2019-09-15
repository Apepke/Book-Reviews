using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookShopAPI.Models;
using DataLibrary;
using static DataLibrary.BusinessLogic.UserProcessor;

namespace BookShopAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult ViewReviews()
        {
            var data = LoadUsers();
            List<UserModel> users = new List<UserModel>();
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


            return View(users);
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        [HttpPost]
        public ActionResult Index(UserModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateUser(model.Name,
                    model.Title,model.Author,model.Review);
                return RedirectToAction("Index");
            }

            return View();
        }

    }
}
