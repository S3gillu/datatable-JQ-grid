using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Datatable.Models
{
    public class Worker
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
       
        public string Position { get; set; }
        
        public string Age { get; set; }
        
        public string StartDate { get; set; }
        public string  Address { get; set; }
        
        public string Email { get; set; }
        public virtual Office Office { get; set; }
    }
}