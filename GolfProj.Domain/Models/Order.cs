using System.ComponentModel.DataAnnotations;

namespace GolfProj.Domain.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int OrderNr { get; set; }
        [Required]
        public int OrderSumKr { get; set; }
        public string OrderDate { get; set; }
        public int CustomerId { get; set; }
    }
}
