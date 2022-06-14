using Lab.Demo.LINQ.Data;
using Lab.Demo.LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.LINQ.Logic
{
    public class CustomersLogic
    {
        private readonly Northwind2Context context;

        public CustomersLogic()
        {
            context = new Northwind2Context();
        }

        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }
    }
}
