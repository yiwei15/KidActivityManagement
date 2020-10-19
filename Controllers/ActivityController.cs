using System.Collections.Generic;
using System.Linq;
using KidActivityManagement.Data;
using KidActivityManagement.Models;
using KidActivityManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KidActivityManagement.Controllers
{
    [Authorize]
    public class ActivityController : Controller
    {
        private ChildActivityDbContext context;
        private readonly UserManager<IdentityUser> _userManager;

        public ActivityController(ChildActivityDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            context = dbContext;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            List<Activity> Activities = context.Activities.ToList();
            return View(Activities);
        }

        [HttpGet]
        public IActionResult Add()
        {
            List<Child> children = context.Children.ToList();

            AddActivityViewModel addActivityViewModel = new AddActivityViewModel(children);
            
            return View(addActivityViewModel);
        } 

        [HttpPost]
        public IActionResult Add(AddActivityViewModel addActivityViewModel, string[] selectedChildren)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(User);
                Activity newActivity = new Activity()
                {
                    Name = addActivityViewModel.Name,
                    StartTime = addActivityViewModel.StartTime,
                    EndTime = addActivityViewModel.EndTime,
                    IsOnline = addActivityViewModel.IsOnline,
                    Location = addActivityViewModel.Location
                };

                context.Activities.Add(newActivity);

                foreach (var childIdString in selectedChildren)
                {
                    int childId = int.Parse(childIdString);
                    ChildActivity newChildActivity = new ChildActivity
                    {
                        Activity = newActivity,
                        ChildId = childId,
                        ActivityId = newActivity.Id,
                        Status = "toDo"
                    };
                    context.ChildActivites.Add(newChildActivity);
                }
                context.SaveChanges();
                return Redirect("Index");
            }

            List<Child> children = context.Children.ToList();

            AddActivityViewModel wrongAddActivityViewModel = new AddActivityViewModel(children);
            wrongAddActivityViewModel.Name = addActivityViewModel.Name;
            wrongAddActivityViewModel.StartTime = addActivityViewModel.StartTime;
            wrongAddActivityViewModel.EndTime = addActivityViewModel.EndTime;
            wrongAddActivityViewModel.IsOnline = addActivityViewModel.IsOnline;
            wrongAddActivityViewModel.Location = addActivityViewModel.Location;
            wrongAddActivityViewModel.ChildIds = addActivityViewModel.ChildIds;

            return View("Add", wrongAddActivityViewModel);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            Activity theActivity = context.Activities.Find(id);
            List<ChildActivity> childActivities = context.ChildActivites
                .Where(ca => ca.ActivityId == id)
                .Include(ca => ca.Child)
                .ToList();

            ActivityDetailViewModel activityDetailViewModel = new ActivityDetailViewModel(theActivity, childActivities);
            return View(activityDetailViewModel);
        }

        public IActionResult EditChildActivity(EditChildActivityViewModel editChildActivityViewModel)
        {


            ChildActivity selectedChildActivity = context.ChildActivites
                .Where(ca => ca.ChildId == editChildActivityViewModel.ChildId)
                .Single(ca => ca.ActivityId == editChildActivityViewModel.ActivityId);

            selectedChildActivity.Status = editChildActivityViewModel.ActivityStatus;
            selectedChildActivity.Note = editChildActivityViewModel.ActivityNote;

            context.SaveChanges();

            Activity theActivity = context.Activities.Find(editChildActivityViewModel.ActivityId);
            List<ChildActivity> childActivities = context.ChildActivites
                .Where(ca => ca.ActivityId == editChildActivityViewModel.ActivityId)
                .Include(ca => ca.Child)
                .ToList();

            ActivityDetailViewModel activityDetailViewModel = new ActivityDetailViewModel(theActivity, childActivities);
            return View("Detail", activityDetailViewModel); 
        }

        public IActionResult EditActivity(int ActivityId, EditActivityViewModel editActivityViewModel)
        {

            Activity updatedActivity = context.Activities.Find(ActivityId);
            updatedActivity.Name = editActivityViewModel.Name;
            updatedActivity.StartTime = editActivityViewModel.StartTime;
            updatedActivity.EndTime = editActivityViewModel.EndTime;
            updatedActivity.Location = editActivityViewModel.Location;
            updatedActivity.IsOnline = editActivityViewModel.IsOnline;

            context.SaveChanges();

            Activity theActivity = context.Activities.Find(ActivityId);
            List<ChildActivity> childActivities = context.ChildActivites
                .Where(ca => ca.ActivityId == editActivityViewModel.ActivityId)
                .Include(ca => ca.Child)
                .ToList();

            ActivityDetailViewModel activityDetailViewModel = new ActivityDetailViewModel(theActivity, childActivities);
            return View("Detail", activityDetailViewModel);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Activity theActivity = context.Activities.Find(id);
            context.Activities.Remove(theActivity);
            context.SaveChanges();

            List<Activity> Activities = context.Activities.ToList();
            return View("Index", Activities);
        }

    }
}
