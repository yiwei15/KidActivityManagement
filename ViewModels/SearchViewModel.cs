using KidActivityManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KidActivityManagement.ViewModels
{
    public class SearchViewModel
    {
        public int ActivityId { get; set; }
        public string Name { get; set; }

        public int ChildId { get; set; }
        public List<Child> Children { get; set; }
        public int[] ChildIds { get; set; }

        [Display(Name = "Start Time")]
        public DateTime StartTime { get; set; }

        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; }

        [Display(Name = "Start Time Choice")]
        public Boolean StartTimeChoice { get; set; }

        [Display(Name = "End Time Choice")]
        public Boolean EndTimeChoice { get; set; }

        public string Online { get; set; }

        public string Status { get; set; }

        public String[] StatusList { get; set; }

        public string SortItem { get; set; }

        public List<ChildActivity> ChildActivities { get; set; }

        public SearchViewModel()
        {
        }

        public SearchViewModel(List<Child> children)
        {
            Children = children;
        }

        public SearchViewModel(List<ChildActivity> childActivities)
        {
            ChildActivities = childActivities;
        }
    }
}
