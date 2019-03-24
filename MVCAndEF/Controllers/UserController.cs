using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAndEF.Models;
namespace MVCAndEF.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }


        //通过多种方式接受数据
        //注意：FormCollection方式要求提交的方式必须为post提交
        [HttpPost]
        public ActionResult AddUser1(string name,string age,string sex,UserInfo user,FormCollection fc)
        {
            string  StrMessage1 = $"姓名：{name},年龄{age},性别{sex}";
            string StrMessage2 = $"姓名：{fc["name"]},年龄{fc["age"]},性别{fc["sex"]}";
            ViewBag.Message1 = StrMessage1;
            ViewData["user"] = user;
            TempData["Message2"] = StrMessage2;
            return View(user);
        }
    }
}