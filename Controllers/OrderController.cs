using AmazonApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmazonApp.Controllers
{
    [Route("Orders")]
    public class OrderController : Controller
    {
        // In-memory lists
        private static List<User> Users = new List<User>
        {
            new User { UserID = 1, UserName = "John Doe", Email = "john@example.com" },
            new User { UserID = 2, UserName = "Jane Smith", Email = "jane@example.com" }
        };

        private static List<Product> Products = new List<Product>
        {
            new Product { ProductID = 1, Name = "Laptop", Category = "Electronics", Price = 1200, StockQuantity = 10 },
            new Product { ProductID = 2, Name = "Smartphone", Category = "Electronics", Price = 800, StockQuantity = 20 }
        };

        private static List<Order> Orders = new List<Order>();

        // GET: /Orders/PlaceOrder
        [HttpGet("PlaceOrder")]
        public IActionResult PlaceOrder()
        {
            ViewData["Products"] = Products; // Pass the product list to the view
            return View();
        }

        // POST: /Orders/CreateOrder
        [HttpPost("CreateOrder")]
        public IActionResult CreateOrder(int userId, int productId, int quantity)
        {
            var user = Users.FirstOrDefault(u => u.UserID == userId);
            var product = Products.FirstOrDefault(p => p.ProductID == productId);

            if (user == null || product == null || quantity <= 0 || product.StockQuantity < quantity)
            {
                return BadRequest("Invalid order details.");
            }

            // Create a new order and order details
            var order = new Order
            {
                OrderID = Orders.Count + 1,
                UserID = userId,
                OrderDetails = new List<OrderDetail>
                {
                    new OrderDetail
                    {
                        OrderDetailID = 1,
                        ProductID = product.ProductID,
                        Quantity = quantity,
                        SubTotal = product.Price * quantity
                    }
                }
            };

            // Add the order to the list of orders
            Orders.Add(order);

            // Update product stock
            product.StockQuantity -= quantity;

            // Redirect to OrderHistory with correct route
            return RedirectToAction("OrderHistory", "Order", new { userId = userId });
        }

        // GET: /Orders/{userId}
        [HttpGet("{userId}")]
        public IActionResult OrderHistory(int userId)
        {
            var userOrders = Orders.Where(o => o.UserID == userId).ToList();

            if (userOrders == null || userOrders.Count == 0)
            {
                return NotFound("No orders found for this user.");
            }

            return View(userOrders); // Display the user's order history
        }
    }
}
