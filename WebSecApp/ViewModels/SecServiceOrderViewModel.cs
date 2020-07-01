using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebSecApp.Models;

namespace WebSecApp.ViewModels
{
    public class SecServiceOrderViewModel
    {
        public IEnumerable<Order> Orders { get; set; }
    }
}
