﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using WebAppyest.Data;
using WebAppyest.Repository;
using WebAppyest.ViewModel;

namespace WebAppyest.Controllers
{
    public class TasksController : Controller
    {
        private DataContext db;
        private readonly ITask _tasks;

        private readonly IWebHostEnvironment hostEnvironment;

        public TasksController(IWebHostEnvironment host, ITask task, DataContext data)
        {
            hostEnvironment = host;
            _tasks = task;
            db = data;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(_tasks.Tasks);
        }

        //[HttpGet]
        //public IActionResult Create(bool isSuccess = false)
        //{
        //    ViewBag.IsSuccess = isSuccess;
        //    return View();
        //}


        //[HttpPost]
        //public IActionResult Create(Tasks task)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _tasks.AddTask(task);
        //        return  RedirectToAction(nameof(Taskboard), new { isSuccess = true });
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}


        [HttpGet]
        public IActionResult Search()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Search(string input)
        {
            var task = _tasks.Search(input);
            return View("SearchOutput", task);
        }



        [HttpGet]
        public IActionResult AddTask()
        {
            var task = new TaskViewModel()
            {
                TaskBoards = db.Tasks.ToList()
            };
            return View(task);

        }





        [HttpPost]
        public IActionResult AddTask(TaskViewModel task)
        {

            if (task.TaskBoard.Id == 0)
            {
                db.Tasks.Add(task.TaskBoard);
                db.SaveChanges();
            }
            else
            {
                var dataInDb = db.Tasks.FirstOrDefault(a => a.Id == task.TaskBoard.Id);
                dataInDb.TaskNumber = task.TaskBoard.TaskNumber;
                dataInDb.DescriptionTitle = task.TaskBoard.DescriptionTitle;
                dataInDb.Description = task.TaskBoard.Description;
                dataInDb.Team = task.TaskBoard.Team;
                dataInDb.StartDate = task.TaskBoard.StartDate;
                dataInDb.EndDate = task.TaskBoard.EndDate;
                dataInDb.Duration = (dataInDb.EndDate - dataInDb.StartDate).TotalDays;
                db.SaveChanges();
                ViewBag.Duraion = (dataInDb.EndDate - dataInDb.StartDate).TotalDays;
            }

            return RedirectToAction(nameof(AddTask), new { isSuccess = true });


            //if (ModelState.IsValid)
            //{
            //    _tasks.AddTask(task);
            //    return RedirectToAction(nameof(AddTask), new { isSuccess = true });
            //}
            //else
            //{
            //    return View();
            //}
        }
    }
}
