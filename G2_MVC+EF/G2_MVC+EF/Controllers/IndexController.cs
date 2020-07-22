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
        public ActionResult Loginget(string Username,string Userpwd)
        {

            var i = db.User.SingleOrDefault(a=>(a.UserAccount== Username && a.UserPwd== Userpwd));
            if (i != null)
            {
                HttpCookie cookie1 = new HttpCookie("username");
                cookie1.Value = i.Uid.ToString();
                Response.AppendCookie(cookie1);
                HttpCookie cookie2 = new HttpCookie("usertype");
                cookie2.Value = i.UserType.ToString();
                Response.AppendCookie(cookie2);
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
            List<Commodity> list = new List<Commodity>();
            list = db.Commodity.Where(a => a.CName.Contains(text)).ToList();
            return JsonConvert.SerializeObject(list);
        }

    }
}