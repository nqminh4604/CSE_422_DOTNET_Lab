using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class UserController : Controller
    {
        private static List<User> _users = new List<User> { 
            new User(1, "Nguyen Van A", "nva@", "012345678"),
            new User(2, "Nguyen Van B", "nvb@", "098765432")
        };

        public IActionResult Index()
        {
            return View(_users);
        }

        private User FindUserById(int Id)
        {
            User user = _users.Find(u => u.Id == Id);
            if (user == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                return user;
            }
        }

        [HttpPost]
        public IActionResult AddUser(string fullName, string email, string phone)
        {

            int lastId = _users.Count > 0 ? _users.Max(c => c.Id) + 1 : 0;

            User user = new User(lastId, fullName, email, phone);
            _users.Add(user);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteUser(int UserId)
        {
            User user = FindUserById(UserId);
            _users.Remove(user);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditUser(User newUser)
        {
            User category = FindUserById(newUser.Id);
            category.FullName = newUser.FullName;
            category.Email = newUser.Email;
            category.PhoneNumber = newUser.PhoneNumber;
            return RedirectToAction("Index");
        }
    }
}
