using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppyest.Data;
using WebAppyest.Models;
using WebAppyest.Repository;
using WebAppyest.ViewModel;

namespace WebAppyest.Controllers
{
    public class ActivityTitleController : Controller
    {
        private readonly IActivityTitle _activity;
        private readonly DataContext _act;
        public ActivityTitleController(IActivityTitle act, DataContext a)
        {
            _activity = act;
            _act = a;
        }
        public IActionResult List(long Id)
        {
            ActivityTitle act = _activity.GetTitle(Id);
            return View(act);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var act = new MultipleActivityModel()
            {
                ActT = _act.ActivityTitleTable.ToList()
            };
            return View(act);
        }
        [HttpPost]
        public IActionResult Create(MultipleActivityModel titl)
        {

            _activity.AddTitle(titl.Acts);
            return RedirectToAction(nameof(Create));

        }

        //private IActionResult RedirectToAction(string v)
        //{
        //    throw new NotImplementedException();
        //}

        [HttpGet]
        public IActionResult Edit(long Id)
        {
            ActivityTitle act = _activity.GetTitle(Id);
            return View(act);
        }
        [HttpPost]
        public IActionResult Edit(ActivityTitle act)
        {
            _activity.EditTitle(act);
            return RedirectToAction(nameof(Create));
        }

        [HttpGet]
        public IActionResult DeleteConfirm(long Id)
        {
            ActivityTitle acti = _activity.GetTitle(Id);
            return View(acti);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(ActivityTitle act, long Id)
        {
            _activity.Delete(Id);
            return RedirectToAction(nameof(Create));
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
