using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidActivityManagement.Models
{
 
        public class Activity
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public Boolean IsOnline { get; set; }
            public string Location { get; set; }
            public string UserId { get; set; }

            public Activity() { }

        }

}
