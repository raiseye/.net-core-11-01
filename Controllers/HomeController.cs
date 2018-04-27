using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCore11_01.Models;
using Newtonsoft.Json;
using System.Threading;


//身份验证
//数据库操作
//api发布
//异步开发
//任务
//控制反转IOC；依赖注入；


namespace NetCore11_01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult json()
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("id", 100);
            dic.Add("name", "hello");
            
            return Json(dic);

        }

        public JsonResult jsonm()
        {
            Memu m = new Memu();
            m.age = 100;
            m.createDate = DateTime.Now;
            m.name = "luther";
            List<Memu> menus  = new List<Memu>();
            menus.Add(m);
            m = new Memu();
            m.age = 50;
            m.createDate = DateTime.Now;
            m.name = "luxing";
            menus.Add(m);
            //处理循环引用问题
            JsonSerializerSettings settings = new JsonSerializerSettings();
            //settings.MaxDepth = 2;
            //settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore; //设置不处理循环引用
            return Json(menus);
        }

        public async Task<IActionResult> Asynctest(int i)
        {
            var bgtime = DateTime.Now;
            int r = await Task.Run(() =>
            {
                Console.WriteLine("异步方法{0}Task被执行", i);
                Thread.Sleep(100);
                return i * 2;
            });
            Console.WriteLine("异步方法{0}执行完毕，结果{1}", i, r);

            if (i == 49)
            {
                Console.WriteLine("用时{0}", (DateTime.Now - bgtime).TotalMilliseconds);
            }

            ViewData["Message"] = (DateTime.Now - bgtime).TotalMilliseconds + 1;
            return View();
        }

    }
}
