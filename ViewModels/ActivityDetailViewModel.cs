using KidActivityManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KidActivityManagement.ViewModels
{
    public class ActivityDetailViewModel
    {
        public int ActivityId { get; set; }
        public string Name { get; set; }

        public List<int> ChildIds { get; set; }
        public List<Child> Children { get; set; }

        [Display(Name = "Start Time")]
        public DateTime StartTime { get; set; }

        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; }

        public TimeSpan duration;

        public readonly int numOfDays;
        public readonly int numOfHours;
        public readonly int numOfMins;

        [Display(Name = "Virtual activity")]
        public Boolean IsOnline { get; set; }

        [Display(Name = "Location or vitual activity login information")]
        public string Location { get; set; }

        public string Status { get; set; }

        public string Note { get; set; }

        public List<ChildActivity>  ChildActivities {get;set;}

        public ActivityDetailViewModel(Activity theActivity, List<ChildActivity> childActivities)
        {
            ActivityId = theActivity.Id;
            Name = theActivity.Name;
            StartTime = theActivity.StartTime;
            EndTime = theActivity.EndTime;
            IsOnline = theActivity.IsOnline;
            Location = theActivity.Location;
            ChildActivities = childActivities;
            duration = theActivity.EndTime - theActivity.StartTime;
            numOfDays = duration.Days;
            numOfHours = duration.Hours;
            numOfMins = duration.Minutes;
        }

    }
}
