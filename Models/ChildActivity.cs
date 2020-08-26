using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidActivityManagement.Models
{
    public class ChildActivity
    {
            public int ChildId { get; set; }
            public Child Child { get; set; }
            public int ActivityId { get; set; }
            public Activity Activity { get; set; }
            public string Status { get; set; }
            public string Note { get; set; }

            public ChildActivity() { }

    }
}
