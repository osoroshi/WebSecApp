using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebSecApp.Models
{
    public class SecServiceRepository: ISecserviceRepository
    {
        private readonly AppDbContext _appDbContext;

        public SecServiceRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<SecService> AllSecService
        {
            get
            {
                return _appDbContext.SecSer;
            }
        }

      

        public SecService GetServiceById(int secId)
        {
            return _appDbContext.SecSer.FirstOrDefault(p => p.id == secId);
        }



    }
}
