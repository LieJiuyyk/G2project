using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebSockets;
using G2_MVC_EF.Models;
using G2_MVC_EF.Models.fenye;
using Newtonsoft.Json;

namespace G2_MVC_EF.Controllers
{
    public class BackstageController : Controller
    {
        MyDBContext DB = new MyDBContext();

        public static PagingHelper<Commodity> CommodityPaging = new PagingHelper<Commodity>(7, new BackstageController().DB.Commodity);

        // GET: Backstage
        public ActionResult Goods(int pageIndex = 1)
        {
            CommodityPaging.PageIndex = pageIndex;//指定当前页
            return View(CommodityPaging);//返回分页器实例到视图
        }

        public ActionResult getGoods(string text)
        {
            CommodityPaging.DataSource = DB.Commodity.Where(a => a.CName.Contains(text));
            PagingHelper<Commodity> data = new PagingHelper<Commodity>(7, CommodityPaging.DataSource);
            CommodityPaging = data;
            return RedirectToAction("Goods", "Backstage");
        }

        public string model_Goods(int id)
        {
            Commodity model = DB.Commodity.SingleOrDefault(a => a.ComId == id);
            return JsonConvert.SerializeObject(model);
        }

        public ActionResult Edit_Goods(int id)
        {
            Commodity model = DB.Commodity.SingleOrDefault(a => a.ComId == id);
            ViewBag.model = model;
            return View(model);
        }

        [HttpPost]
        public ActionResult EditGoods(int ComId, string CName, decimal Cprice, HttpPostedFileBase CpicUrl1, HttpPostedFileBase CpicUrl2, HttpPostedFileBase CpicUrl3, HttpPostedFileBase CpicUrl4, HttpPostedFileBase CpicUrl5, HttpPostedFileBase CpicUrl6, int Bid, int CateID)
        {
            Commodity model = DB.Commodity.SingleOrDefault(a => a.ComId == ComId);

            if (CpicUrl1 != null && CpicUrl1.ContentLength != 0)
            {
                string p = CpicUrl1.FileName;
                string pach = Server.MapPath("~/images/" + p);
                //保存到服务器指定文件夹中
                CpicUrl1.SaveAs(pach);
                model.CpicUrl1 = p;
            }

            if (CpicUrl2 != null && CpicUrl2.ContentLength != 0)
            {
                string p2 = CpicUrl2.FileName;
                string pach2 = Server.MapPath("~/images/" + p2);
                //保存到服务器指定文件夹中
                CpicUrl2.SaveAs(pach2);
                model.CpicUrl2 = p2;
            }

            if (CpicUrl3 != null && CpicUrl3.ContentLength != 0)
            {
                string p3 = CpicUrl3.FileName;
                string pach3 = Server.MapPath("~/images/" + p3);
                //保存到服务器指定文件夹中
                CpicUrl3.SaveAs(pach3);
                model.CpicUrl3 = p3;
            }

            if (CpicUrl4 != null && CpicUrl4.ContentLength != 0)
            {
                string p4 = CpicUrl4.FileName;
                string pach4 = Server.MapPath("~/images/" + p4);
                //保存到服务器指定文件夹中
                CpicUrl4.SaveAs(pach4);
                model.CpicUrl4 = p4;
            }

            if (CpicUrl5 != null && CpicUrl5.ContentLength != 0)
            {
                string p5 = CpicUrl5.FileName;
                string pach5 = Server.MapPath("~/images/" + p5);
                //保存到服务器指定文件夹中
                CpicUrl5.SaveAs(pach5);
                model.CpicUrl5 = p5;
            }

            if (CpicUrl6 != null && CpicUrl6.ContentLength != 0)
            {
                string p6 = CpicUrl6.FileName;
                string pach6 = Server.MapPath("~/images/" + p6);
                //保存到服务器指定文件夹中
                CpicUrl6.SaveAs(pach6);
                model.CpicUrl6 = p6;
            }

            model.CName = CName;
            model.Cprice = Cprice;
            model.Bid = Bid;
            model.CateID = CateID;

            int i = DB.SaveChanges();
            CommodityPaging.DataSource = DB.Commodity.Where(a => a.CName.Contains(CName.Substring(0,2)));

            //添加完成后转到首页
            if (i == 1)
                return Redirect("/Backstage/Goods");
            else
                return Redirect("/Backstage/Add_Goods");
        }

        public ActionResult Add_Goods()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddGoods(string CName, decimal Cprice, HttpPostedFileBase CpicUrl1, HttpPostedFileBase CpicUrl2, HttpPostedFileBase CpicUrl3, HttpPostedFileBase CpicUrl4, HttpPostedFileBase CpicUrl5, HttpPostedFileBase CpicUrl6, int Bid, int CateID)
        {
            Commodity model = new Commodity();

            if (CpicUrl1 != null && CpicUrl1.ContentLength != 0)
            {
                var last = CpicUrl1.FileName.Substring(CpicUrl1.FileName.LastIndexOf('.'));
                //判断是否为图片文件
                if (last == ".png" || last == ".jpg" || last == ".bmp")
                {
                    string p = CpicUrl1.FileName;
                    string pach = Server.MapPath("~/images/" + p);
                    //保存到服务器指定文件夹中
                    CpicUrl1.SaveAs(pach);
                    if (CpicUrl2 != null && CpicUrl2.ContentLength != 0)
                    {
                        string p2 = CpicUrl2.FileName;
                        string pach2 = Server.MapPath("~/images/" + p2);
                        //保存到服务器指定文件夹中
                        CpicUrl2.SaveAs(pach2);
                        model.CpicUrl2 = p2;
                    }
                    if (CpicUrl3 != null && CpicUrl3.ContentLength != 0)
                    {
                        string p3 = CpicUrl3.FileName;
                        string pach3 = Server.MapPath("~/images/" + p3);
                        //保存到服务器指定文件夹中
                        CpicUrl3.SaveAs(pach3);
                        model.CpicUrl3 = p3;
                    }
                    if (CpicUrl4 != null && CpicUrl4.ContentLength != 0)
                    {
                        string p4 = CpicUrl4.FileName;
                        string pach4 = Server.MapPath("~/images/" + p4);
                        //保存到服务器指定文件夹中
                        CpicUrl4.SaveAs(pach4);
                        model.CpicUrl4 = p4;
                    }
                    if (CpicUrl5 != null && CpicUrl5.ContentLength != 0)
                    {
                        string p5 = CpicUrl5.FileName;
                        string pach5 = Server.MapPath("~/images/" + p5);
                        //保存到服务器指定文件夹中
                        CpicUrl5.SaveAs(pach5);
                        model.CpicUrl5 = p5;
                    }
                    if (CpicUrl6 != null && CpicUrl6.ContentLength != 0)
                    {
                        string p6 = CpicUrl6.FileName;
                        string pach6 = Server.MapPath("~/images/" + p6);
                        //保存到服务器指定文件夹中
                        CpicUrl6.SaveAs(pach6);
                        model.CpicUrl6 = p6;
                    }
                    
                    model.CName = CName;
                    model.Cprice = Cprice;
                    model.CpicUrl1 = p;             
                    model.Bid = Bid;
                    model.CateID = CateID;
                    DB.Commodity.Add(model);
                    int i = DB.SaveChanges();

                    //添加完成后转到首页
                    if (i == 1)
                        return Redirect("/Backstage/Goods");
                    else
                        return Redirect("/Backstage/Add_Goods");
                }
                else
                {
                    return Content("上传图片后缀名无效");
                }
            }
            else
            {
                return Content("上传失败！");
            }           
            
        }

        public ActionResult Det_Goods(int id)
        {
            Commodity model = DB.Commodity.SingleOrDefault(a => a.ComId == id);
            DB.Commodity.Remove(model);
            int i = DB.SaveChanges();
            if (i == 1)
                return Redirect("/Backstage/Goods");
            else
                return Redirect("/Backstage/Goods");
        }
    }
}