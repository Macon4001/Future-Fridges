using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FutureFridgesCW.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }

        public string SupplierEmail { get; set; }

        public int SupplierPhone { get; set; }

        public string SupplierAddress { get; set; }

    }
}