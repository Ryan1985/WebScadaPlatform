using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebScadaPlatform.Models;

namespace WebScadaPlatform.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(UserModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (model.UserName=="admin")
                {
                    return RedirectToAction("Index", "Home");
                }


                //var _user = userService.Find(loginViewModel.UserName);
                //if (_user == null) ModelState.AddModelError("UserName", "用户名不存在");
                //else if (_user.Password == Common.Security.Sha256(loginViewModel.Password))
                //{
                //    var _identity = userService.CreateIdentity(_user, DefaultAuthenticationTypes.ApplicationCookie);
                //    AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
                //    AuthenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = loginViewModel.RememberMe }, _identity);
                //    return RedirectToAction("Index", "Home");
                //}
                //else ModelState.AddModelError("Password", "密码错误");
            }
            ViewBag.ErrorInfo = "用户名密码错误";
            return View();
        }


	}
}