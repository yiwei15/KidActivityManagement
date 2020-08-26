using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KidActivityManagement.Data;
using KidActivityManagement.Models;
using KidActivityManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KidActivityManagement.Controllers
{
    [Authorize]
    public class ChildController : Controller
    {
        private ChildActivityDbContext context;
        private readonly UserManager<IdentityUser> _userManager;

        public ChildController(ChildActivityDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            context = dbContext;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            List<Child> children = context.Children.Where(c => c.UserId == userId).ToList();

            return View(children);
        }

        public IActionResult Add()
        {
            
            return View();
        }
      
        [HttpPost]
        public IActionResult ProcessAddChild(AddChildViewModel addChildViewModel)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(User);
                Child newChild = new Child
                {
                    Name = addChildViewModel.Name,
                    Gender = addChildViewModel.Gender,
                    DOB = addChildViewModel.DOB,
                    UserId = userId
                };
                context.Children.Add(newChild);
                context.SaveChanges();
                return Redirect("Index");
            }

            return View("Add", addChildViewModel);
        }

        public IActionResult Delete()
        {
            List<Child> children = context.Children.ToList();

            return View(children);
        }

        [HttpPost]
        public IActionResult Delete(int[] childIds)
        {
            foreach (int childId in childIds)
            {
                Child theChild = context.Children.Find(childId);
                context.Children.Remove(theChild);
            }

            context.SaveChanges();

            return Redirect("/Child");
        }
    }
}
