using BasicExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicExample.Controllers
{
    public class CustomerOrdersController : Controller
    {
        // GET: CustomerOrdersController
        public ActionResult Index()
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Burak",
                LastName = "Özkan",
                Email = "burak@gmail.com"
            };

            List<Order> orders = new List<Order>
            {
                new Order { Id= 1, ProductName= "Laptop", Price= 25000, Quantity= 1 },
                new Order { Id= 2, ProductName= "Mouse", Price= 2100, Quantity= 1 },
                new Order { Id= 3, ProductName= "Keyboard", Price= 1500, Quantity= 1 }
            };

            CustomerOrdersVievModel customerOrdersVievModel = new CustomerOrdersVievModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(customerOrdersVievModel);
        }

    }
}
