using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_sql.Models;

namespace mvc_sql.Controllers
{
    public class HomeController : Controller
    {
        public List<Db> DbRecords = new List<Db> { new TextDb() };
        //private IDb db = new TextDb();
        //private IDb db = TextDb.createClass();
            
        public IActionResult Index()
        {
            return View();
        }

        public string Help(string name)
        {
            return "Hi this is my SQL server, supported methods: Get(http://localhost:5000/Home/Get?id=1),Add(http://localhost:5000/Home/Set?id=1&name=user&group=grp&faculty=fac&university=psu),Del(http://localhost:5000/Home/Del?id=1)";
        }

        public string Get(int id)
        {
            IDb db = DbRecords[0];
            return db.Get(id);
        }

        public string Set(int id, string name, string group, string faculty, string university)
        {
            return "Set: Id: '" + id.ToString() +
            "', Name: '" + name +
            "', Group: '" + group +
            "', Facylty: '" + faculty +
            "', University: '" + university +
            "'";
        }

        public string Del(int id)
        {
            return "Del: " + id.ToString();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
