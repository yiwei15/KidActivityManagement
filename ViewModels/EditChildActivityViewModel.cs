using KidActivityManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KidActivityManagement.ViewModels
{
    public class EditChildActivityViewModel
    {
        public int ChildId { get; set; }

        public int ActivityId { get; set; }
        public string ActivityStatus { get; set; }

        public string ActivityNote { get; set; }

        public EditChildActivityViewModel() { }

    }
}
