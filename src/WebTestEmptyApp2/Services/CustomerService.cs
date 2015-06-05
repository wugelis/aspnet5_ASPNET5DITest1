using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using WebTestEmptyApp2.Models;

namespace WebTestEmptyApp2.Services
{
    public class CustomerService : ICustomer
    {
        public IEnumerable<Customer> GetData()
        {
            return new List<Customer>(new Customer[] {
                new Customer() { CusID = "1", CusName = "Gelis Wu"},
                new Customer() { CusID = "2", CusName = "Allan"}
            }).AsEnumerable();
        }
    }
}