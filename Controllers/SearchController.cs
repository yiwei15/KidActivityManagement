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
using Microsoft.EntityFrameworkCore;

namespace KidActivityManagement.Controllers
{
    [Authorize]
    public class SearchController : Controller
    {
        private ChildActivityDbContext context;
        private readonly UserManager<IdentityUser> _userManager;

        public SearchController(ChildActivityDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            context = dbContext;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            List<Child> children = context.Children.ToList();
            SearchViewModel searchViewModel = new SearchViewModel(children);

            return View(searchViewModel);
        }

        [HttpPost]
        [HttpGet]
        public IActionResult SearchResult(SearchViewModel searchViewModel)
        {

            List<bool> onlineList = new List<bool>();
            if (searchViewModel.Online == "yes")
            {
                onlineList.Add(true);
            }
            if (searchViewModel.Online == "no")
            { 
                onlineList.Add(false); 
            }
            if (searchViewModel.Online == null || searchViewModel.Online == "both")
            {
                onlineList.Add(true);
                onlineList.Add(false);
            }


            var query = context.ChildActivites
                 .Where(ca => onlineList.Contains(ca.Activity.IsOnline));
            if (searchViewModel.ChildIds != null)
            {
                query = query.Where(ca => searchViewModel.ChildIds.Contains(ca.ChildId));
            }
            if (searchViewModel.StatusList != null)
            {
                query = query.Where(ca => searchViewModel.StatusList.Contains(ca.Status));
            }
            if (searchViewModel.StartTimeChoice)
            {
                query = query.Where(ca => ca.Activity.StartTime > searchViewModel.StartTime);
            }
            if (searchViewModel.EndTimeChoice)
            {
                query = query.Where(ca => ca.Activity.EndTime < searchViewModel.EndTime);
            }   
                 
            if (searchViewModel.SortItem != null)
            {
                switch(searchViewModel.SortItem)
                {
                    case "ChildId":
                        query = query.OrderBy(ca => ca.Child.Name);
                        break;
                    case "StartTime":
                        query = query.OrderBy(ca => ca.Activity.StartTime);
                        break;
                    case "IsOnline":
                        query = query.OrderBy(ca => ca.Activity.IsOnline);
                        break;
                    case "Status":
                        query = query.OrderBy(ca => ca.Status);
                        break;
                }

            }
            
            query = query.Include(ca => ca.Activity)
                 .Include(ca => ca.Child);

            List<ChildActivity> selectedChildActivity = query.ToList();
            searchViewModel.ChildActivities = selectedChildActivity;
            return View(searchViewModel);
        }

        //[HttpGet]
        //public IActionResult All()
        //{
        //    List<ChildActivity> allChildActivity;
        //    allChildActivity = context.ChildActivites
        //         .Include(ca => ca.Activity)
        //         .Include(ca => ca.Child)
        //         .ToList();
        //    SearchViewModel searchViewModel = new SearchViewModel();
        //    searchViewModel.ChildIds = new int[0];
        //    searchViewModel.StatusList = new string[0];

        //    searchViewModel.ChildActivities = allChildActivity;
        //    return View("SearchResult", searchViewModel);
        //}

    }
}
