using KidActivityManagement.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidActivityManagement.ViewModels
{
    public class AddChildActivityViewModel
    {
        public int ChildId { get; set; }
        public Child child { get; set; }

        public int ActivityId { get; set; }
        public List<SelectListItem> Activities { get; set; }


    }
}
