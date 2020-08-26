using KidActivityManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidActivityManagement.ViewModels
{
    public class ChildDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }

        public List<Activity> Activites { get; set; }
    }
}
