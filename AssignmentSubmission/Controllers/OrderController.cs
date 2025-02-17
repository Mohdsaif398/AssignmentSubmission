using AssignmentSubmission.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AssignmentSubmission.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProcessOrder(OrderModel order)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Index", order);
                }

                await Task.Run(() =>
                {
                    // Simulate processing delay
                    Task.Delay(500).Wait();

                    // Apply discount logic
                    if (order.OrderAmount >= 100 && order.CustomerType == "Loyal")
                    {
                        order.Discount = order.OrderAmount * 0.10m;
                    }
                });

                return View("Result", order);
            }
            catch (Exception ex)
            {
                // Log error (if needed)
                Console.WriteLine($"Error: {ex.Message}");

                ViewBag.ErrorMessage = "An error occurred while processing your order.";
                return View("Index", order);
            }
        }
    }
}
