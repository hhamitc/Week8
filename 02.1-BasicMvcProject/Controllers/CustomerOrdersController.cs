using _02._1_BasicMvcProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02._1_BasicMvcProject.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Hamit";
            customer1.LastName = "Canpolat";
            customer1.Email = "hamit@h.com";

            var orders = new List<Order>()
            {
            new Order { Id = 1, ProductName = "Laptop", Price = 45000, Quantity = 21 },
            new Order { Id = 2, ProductName = "Destktop", Price = 27000, Quantity = 14 },
            new Order { Id = 3, ProductName = "Phone", Price = 16000, Quantity = 56 },
            new Order { Id = 4, ProductName = "Tablet", Price = 9000, Quantity = 33 }
            };

            var viewModel = new CustomerOrderViewModel()
            {
                Customer = customer1,
                Orders = orders
            };


            return View(viewModel);
        }
    }
}
