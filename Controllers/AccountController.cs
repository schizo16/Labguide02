using Labguide02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labguide02.Controllers
{
    
    public class AccountController : Controller
    {
        [Route("account", Name="account")]
        public IActionResult Index()
        {
            
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1,Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("images/avatar/1 (1).jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                    Id = 2,Name="Trường Giang",
                    Email="giang@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("images/avatar/1 (2).jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                    Id = 3,Name="Hoàng Thúy",
                    Email="thuy@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("images/avatar/1 (3).jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                    Id = 4, Name ="Tuấn Anh",
                    Email="tuananh@gmail.com",
                    Phone="0967869807",
                    Address="Hà Nội",
                    Avatar = Url.Content("images/avatar/1 (4).jpg"),
                    Gender=1, Bio="Hell World",
                    Birthday= new DateTime(2002,1,16)
                },
            };
            ViewBag.Accounts = accounts;
            return View();
        }
        [Route("ho-so-cua-toi", Name ="profile")]
        public IActionResult Profile()
        {
            Account account = new Account()
            {
                Id = 1,
                Name = "Hoàng Anh",
                Email = "anh@gmail.com",
                Phone = "0986456789",
                Address = "Hà Nội",
                Avatar = "/images/Avatar/1 (1).jpg",
                Gender = 1,
                Bio = "My name is small",
                Birthday = new DateTime(1998, 7, 15)
            };
            ViewBag.account = account;
            return View();
        }
    }
}
