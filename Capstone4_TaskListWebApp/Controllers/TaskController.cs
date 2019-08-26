using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Capstone4_TaskListWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Capstone4_TaskListWebApp.Controllers
{
    [Authorize]
    public class TaskController : Controller
    {
        private readonly TaskListDbContext _context;
        public TaskController(TaskListDbContext context)
        {
            _context = context;
        }

        public IActionResult ListTasks()
        {
            string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            List<Tasks> taskList = _context.Tasks.ToList();
            List<Tasks> userTaskList = new List<Tasks>();
            foreach(var task in taskList)
            {
                if(id == task.UserId)
                {
                    userTaskList.Add(task);
                }
            }

                
            return View(userTaskList);
        }

        public IActionResult AddTask()
        {
            
            return View();

        }
        [HttpPost]
        public IActionResult AddTask(Tasks newTask)
        {
            string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            newTask.UserId = id;
            if (ModelState.IsValid)
            {
                _context.Tasks.Add(newTask);
                _context.SaveChanges();
            }
            return RedirectToAction("ListTasks");

        }

        public IActionResult DeleteTask(int Id)
        {
            Tasks found = _context.Tasks.Find(Id);
            if (ModelState.IsValid)
            {
                _context.Tasks.Remove(found);
                _context.SaveChanges();
            }
            return RedirectToAction("ListTasks");
        }

     
       public IActionResult UpdateTask(int Id)
       {
           Tasks found = _context.Tasks.Find(Id);
           if (ModelState.IsValid && found != null)
           {

               
               found.Complete = "Yes";

               _context.Entry(found).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
               _context.Update(found);
               _context.SaveChanges();



           }
           return RedirectToAction("ListTasks");
           

       }



    }
}