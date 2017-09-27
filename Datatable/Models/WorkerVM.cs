using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Datatable.Models
{
    public class WorkerVM
    {
        public int Id { get; set; }

        public IEnumerable<Position> List { get; set; }
        public Worker Employees { get; set; }
        
    }
}