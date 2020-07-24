using G2_MVC_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace G2_MVC_EF.Controllers
{
    
    public class IndexController : Controller
    {

        // GET: Index
        public Models.MyDBContext db = new Models.MyDBContext();
        public ActionResult Index()
        {
            ViewBag.li = db.Category.ToList();
            ViewData["messages"] = db.Brand.ToList();
            ViewData["td"] = db.Commodity.ToList();
            
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        //注册
        public ActionResult sginup()
        {
            return View();
        }
        public ActionResult Getsginup(string Username, string email, string password)
        {
           var so= db.User.FirstOrDefault(a => a.UserAccount == Username);
            if (so==null)
            {
                G2_MVC_EF.Models.User user = new User();
                user.UserAccount = Username;
                user.Userphone = email;
                user.UserPwd = password;
                db.User.Add(user);
                int i = db.SaveChanges();
                if (i == 1)
                {
                    return Redirect("/Index/Login");
                }
            }
            else
            {
                return Content("<script>alert('用户已被注册');window.location.href='/Index/sginup';</script>");
            }
            return Content("<script>alert('注册失败');</script>");

        }
        //登录
        public ActionResult Loginget(string Username,string Userpwd)
        {

            var i = db.User.SingleOrDefault(a=>(a.UserAccount== Username && a.UserPwd== Userpwd));
            Session["userID"]= i.Uid;
            if (i != null)
            {
                return Content("{\"isdat\":\"true\"}");
            }
            else
                return Content("{\"isdat\":\"false\"}");
        }

        public ActionResult Categet(int id)
        {

           ViewData["Categet"] =db.Commodity.Where(a => a.CateID == id).ToList();
            return View();
        }
        public ActionResult shangpxq(int id)
        {
           ViewBag.list2 =db.Commodity.SingleOrDefault(a=>a.ComId==id);
            return View();
        }

        [HttpGet]
        public string GetModelByID(int id)
        {
            Commodity commodity = db.Commodity.SingleOrDefault(a => a.ComId == id);
            return JsonConvert.SerializeObject(commodity);
        }
        //public string GettxtBox(string text)
        //{

        //    List<Category> list = new List<Category>();
        //    list = db.Category.Where(a => a.CateName.Contains(text)).ToList();
        //    return JsonConvert.SerializeObject(list).ToString();
        //}
        public string Gettxt1(string text)
        {
            List<ShopClass> list = new List<ShopClass>();
            list = db.Commodity.Where(a => a.CName.Contains(text)).Select(a=>new ShopClass{CName=a.CName,ComId=a.ComId }).ToList();
            return JsonConvert.SerializeObject(list);
        }
        //购物车
        public ActionResult BuyCart()
        {
            return View();
        }
    }
}