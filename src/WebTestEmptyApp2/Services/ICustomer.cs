using System;
using System.Collections.Generic;
using WebTestEmptyApp2.Models;

namespace WebTestEmptyApp2.Services
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetData();
    }
}