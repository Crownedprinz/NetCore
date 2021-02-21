using System;
using System.Linq;
using DebbyTest.DATA;
using DebbyTest.Models.Customers;

namespace DebbyTest.Services
{
    public class CustomerService
    {
        private MainContext _context;
        public CustomerService(MainContext context)
        {
            _context = context;
        }

        public Tbl_Customer GetOneCustomer()
        {
            return _context.Tbl_Customer.FirstOrDefault(); 
        }


    }
}
