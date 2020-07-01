using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSecApp.Models
{
    public class SecService
    {
        [Key]
        public int id { get; set; }
        public string prodcode { get; set; }
        public string servName { get; set; }
        public string technology { get; set; }
        public string projecttype { get; set; }
        public int projduration { get; set; }
        public DateTime startdate { get; set; }
        public DateTime finishdate { get; set; }

    }
}
