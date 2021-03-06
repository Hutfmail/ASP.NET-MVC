﻿using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MVCDemo.Controllers
{
    public class LoginByAjaxWithJsonController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            ViewData["Time"] = DateTime.Now.ToString();
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Name, string Pwd)
        {
            if (Name == "admin")
            {
                ReturnData<Person> rd = new ReturnData<Person>()
                {
                    Message = "用户名正确",
                    Success = true,
                    Redirect = "http://www.baidu.com",
                    Data = new List<Models.Person>()
                    {
                        new Person() { Id = 1, Name = "shanzm1" },
                        new Person() { Id = 2, Name = "shanzm2" }
                    }
                };
                //JavaScriptSerializer jss = new JavaScriptSerializer();
                //return Content(jss.Serialize(rd));
                return Json(rd);
            }
            else
            {
                ViewData["Time"] = DateTime.Now.ToString();
                ReturnData<Person> rd = new ReturnData<Person>()
                {
                    Message = "用户名错误",
                    Success = true,
                    Redirect = "http://www.baidu.com",
                    Data = new List<Models.Person>()
                    {
                        new Person() { Id = 1, Name = "shanzm1" },
                        new Person() { Id = 2, Name = "shanzm2" }
                    }
                };
                return Json(rd);
            }
        }


    }
}