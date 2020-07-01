using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSecApp.Models
{
    public interface ISecserviceRepository
    {
       // IEnumerable<SecService> AllSecService { get; }

        IEnumerable<SecService> AllSecService { get; }

       // SecService GetSecServicebyId(int SecServiceId);

        SecService GetServiceById(int secId);

    }
}
