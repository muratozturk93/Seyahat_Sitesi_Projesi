using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Seyahat_Sitesi_Projesi.Models.Siniflar;

namespace Seyahat_Sitesi_Projesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler=c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog parametre) 
        {
            c.Blogs.Add(parametre);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var blog = c.Blogs.Find(id);
            c.Blogs.Remove(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var blog = c.Blogs.Find(id);
            return View("BlogGetir",blog);
        }
        public ActionResult BlogGuncelle(Blog b)
        {
            var blog = c.Blogs.Find(b.Id);
            blog.Aciklama= b.Aciklama;
            blog.Tarih=b.Tarih;
            blog.BlogImage=b.BlogImage;
            blog.Baslik=b.Baslik;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }

        public ActionResult YorumSil(int id)
        {
            var blog = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(blog);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}