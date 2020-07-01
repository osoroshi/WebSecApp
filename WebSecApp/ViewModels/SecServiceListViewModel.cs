using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSecApp.Models;

namespace WebSecApp.ViewModels
{
    public class SecServiceListViewModel
    {
        public IEnumerable<SecService> SecServices { get; set; }
    }
}
