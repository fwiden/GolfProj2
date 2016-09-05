using GolfProj.Domain.Models;
using System.Collections.Generic;

namespace GolfProj.Domain.Repositories
{
    public interface IGolfRepository
    {
        IList<Customer> GetAllCustomers();
        IList<Order> GetAllOrders();

    }
}
