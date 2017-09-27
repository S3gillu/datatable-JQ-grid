using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Datatable.Models
{
    public class Office
    {
        public int OfficeId { get; set; }
        public string OfficePlace { get; set; }
        public string StartDate { get; set; }
        public int Salary { get; set; }
        public int WorkerId { get; set; }
        public virtual ICollection<Worker> Workers { get; set; }

    }
}