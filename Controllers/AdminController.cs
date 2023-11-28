using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test1.Models;

namespace test1.Controllers
{
    public class AdminController : Controller
    {
        public DatabaseDataContext db = new DatabaseDataContext();

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult tables()
        {
            return View();
        }
        public ActionResult productviews()
        {
            return View();
        }
        public ActionResult dashboard()
        {
            return View();
        }
        public ActionResult addproducts()
        {
            return View();
        }

        public string Add()
        {
            //ví dụ về linq to sql
            //var qr = db.tbl_SVs; //select * from tbl_SV
            //var qr1 = db.tbl_SVs.Where(o => o.MSSV == "1234"); //select * from tbl_SV where mssv == "1234"

            string URL = Request["p-image"];
            string prdname = Request["p-name"];
            string price = Request["p-price"];
            string categoryID = Request["p-categoryID"];
            string desc = Request["p-desc"];

            //validate input
            //if (!string.IsNullOrEmpty(URL) && !string.IsNullOrEmpty(prdname) && !string.IsNullOrEmpty(categoryID) && !string.IsNullOrEmpty(price) && !string.IsNullOrEmpty(de))
           // {    
                    try
                    {
                        //trường hợp muốn insert
                        Product prd = new Product();
                        prd.URL = URL;
                        prd.NameProduct = prdname;
                        prd.CategoryID = int.Parse(categoryID);
                        prd.Price = double.Parse(price);
                        prd.Description = desc;

                        db.Products.InsertOnSubmit(prd);
                        db.SubmitChanges();

                        return "Thêm mới sản phẩm thành công";
                    }
                    catch (Exception ex)
                    {
                        return "Thêm mới sản phẩm thất bại. Chi tiết lỗi: " + ex.Message;
                    }
                    //ok
                    //return "MSSV: " + mssv + "; Họ tên: " + hoten + "; Mật khẩu: " + mk;
                

           // }
            //else
            //{
            //    return "Mày chơi tao không được đâu";
            //}


        }
    }
}