using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using WebAppyest.ActivitiesViewModels;
using WebAppyest.Models;
using WebAppyest.ServiceRepository;

namespace WebAppyest.Controllers
{
    public class ActivitiesController : Controller
    {
        private readonly IActivities _activity;
        private readonly IWebHostEnvironment hostingEnvironment;
        private readonly DataContext context;
        public ActivitiesController(IActivities act, IWebHostEnvironment host, DataContext con)
        {
            _activity = act;
            hostingEnvironment = host;
            context = con;
        }

        [HttpGet]
        public IActionResult Create()
        {
            var act = new MultipleActivityModel()
            {
                Act = context.ActivitiesTable.ToList()
                
            };
            ViewBag.Titles = context.ActivityTitleTable;
            return View(act);
        }
        public IActionResult Create(MultipleActivityModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                string uniqueActName = null;
                if (model.ActViewModel.ActImage != null && model.ActViewModel.ActManagerImage != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images/activity");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ActViewModel.ActImage.FileName;
                    uniqueActName = Guid.NewGuid().ToString() + "_" + model.ActViewModel.ActManagerImage.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    string pathfile = Path.Combine(uploadsFolder, uniqueActName);
                    model.ActViewModel.ActImage.CopyTo(new FileStream(filePath, FileMode.Create));
                    model.ActViewModel.ActManagerImage.CopyTo(new FileStream(pathfile, FileMode.Create));
                }
                Activities newActivities = new Activities
                {
                    ActivityNumber = model.ActViewModel.ActivityNumber,
                    ActivityTitle = model.ActViewModel.ActivityTitle,
                    Description = model.ActViewModel.Description,
                    SelectTeam = model.ActViewModel.SelectTeam,
                    ActivityImage = uniqueFileName,
                    ActivityManagerImage = uniqueActName,
                    Start = model.ActViewModel.Start,
                    End = model.ActViewModel.End

                };
                _activity.AddActivities(newActivities);
                return RedirectToAction(nameof(Create));
            }
            
            return View("Create");
        }

        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string Name, long num)
        {

            var result = _activity.Search(Name, num);
            return View("SearchResult", result);

        }
    }
}