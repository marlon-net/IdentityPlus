using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using IdentityPlus.Models;

namespace IdentityPlus.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        ApplicationDbContext _context;

        public UserController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Users
        [Authorize]
        public ActionResult Index()
        {
            var Users = _context.Users.ToList();

            return View(Users);
        }


    }
}