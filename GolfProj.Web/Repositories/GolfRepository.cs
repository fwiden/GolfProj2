using GolfProj.Domain.Models;
using GolfProj.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolfProj.Web.Repositories
{
    public class GolfRepository: IGolfRepository
    {
        public IList<Customer> GetAllCustomers()
        {

        }

        public IList<Order> GetAllOrders()
        {

        }
    }
}