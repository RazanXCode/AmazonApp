namespace AmazonApp.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
