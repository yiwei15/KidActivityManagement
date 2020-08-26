using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KidActivityManagement.ViewModels
{
    public class AddChildViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        public string Gender { get; set; }

        [Range(typeof(DateTime), "01/01/1900", "01/01/2021", ErrorMessage = "Date is out of Range")]
        public DateTime DOB { get; set; }

}
}
