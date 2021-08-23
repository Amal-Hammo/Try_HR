using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using test1.Models;

namespace test1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Context cnt;
        public HomeController(ILogger<HomeController> logger, Context cnt)
        {
            _logger = logger;
            this.cnt = cnt;
        }
        public IActionResult Index()
        {
            return View(cnt.MoveTypes.ToList());
        }
        public IActionResult AllMove()
        {
            return View(cnt.MovementRecords.Include(c => c.MoveType).ToList());
        }
        public void AddData(int StateID)
        {
            cnt.MovementRecords.Add(new MovementRecord()
            { MoveDate = DateTime.Now, MoveID = StateID, UID = 1 });
            cnt.SaveChanges();
        }
        public bool CheckData(int StateID)
        {
            var res = cnt.MovementRecords.Where(c => c.MoveDate.Date == DateTime.Today.Date
                       && c.UID == 1 && c.MoveID == 1);
            switch (StateID){
                case 1:                    
                    if (res.Count() > 0) { return false; }
                    else { AddData(StateID); return true; }
                    break;
                case 2:
                    if (res.Count() > 0)
                    {
                        var re2 = cnt.MovementRecords.Where(c => c.MoveDate.Date == DateTime.Today.Date
                              && c.UID == 1 && c.MoveID == 2);
                        if (re2.Count() > 0)
                        {
                            return false;
                        }
                        var re = cnt.MovementRecords.Where(c => c.MoveDate.Date == DateTime.Today.Date
                         && c.UID == 1 && c.MoveID == 3);
                        if (re.Count() > 0)
                        {
                            var re1 = cnt.MovementRecords.Where(c => c.MoveDate.Date == DateTime.Today.Date
                              && c.UID == 1 && c.MoveID == 4);
                            if (re1.Count() > 0)
                            {
                                AddData(StateID);
                                return true;
                            }
                            return false;
                        }
                        else
                        {
                            AddData(StateID);
                            return true;
                        }
                    }
                    break;
                case 3:
                    if (res.Count() > 0)
                    {
                        var re = cnt.MovementRecords.Where(c => c.MoveDate.Date == DateTime.Today.Date
                         && c.UID == 1 && c.MoveID == 2);
                        if (re.Count() > 0)
                        { return false; }
                        else
                        {
                            AddData(StateID);
                            return true;
                        }
                    }
                    break;
                case 4:
                    var re4 = cnt.MovementRecords.Where(c => c.MoveDate.Date == DateTime.Today.Date
                              && c.UID == 1 && c.MoveID == 4);
                    if (re4.Count() > 0)
                    {
                        return false;
                    }
                    var res1 = cnt.MovementRecords.Where(c => c.MoveDate.Date == DateTime.Today.Date
                     && c.UID == 1 && c.MoveID == 3);
                    if (res1.Count() > 0)
                    {
                        AddData(StateID);
                        return true;
                    }
                    break;              
            }
                
            return false;
        }
        public JsonResult ChekData(int tid)
        {
            if (CheckData(tid)) { return Json("Success"); }
            return Json("Faild");
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
