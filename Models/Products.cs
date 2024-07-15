using System.ComponentModel.DataAnnotations;

namespace FutureFridgesCW.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public int quantity { get; set; }

        public string expiryDate { get; set; }
    }
}
