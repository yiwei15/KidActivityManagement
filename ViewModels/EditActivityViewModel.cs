using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KidActivityManagement.ViewModels
{
    public class EditActivityViewModel
    {
        public int ActivityId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Start time is required.")]
        [Display(Name = "Start Time")]
        public DateTime StartTime { get; set; }

        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; }

        [Display(Name = "Is a vitual activity?")]
        public Boolean IsOnline { get; set; }

        [Display(Name = "Location or vitual activity login information")]
        public string Location { get; set; }

        public EditActivityViewModel() { }



    }
}
