using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSecApp.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);

        void DeleteOrder(Order order);

        IEnumerable<Order> AllOrders { get; }

    }
}
