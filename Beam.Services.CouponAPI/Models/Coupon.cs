using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Beam.Services.CouponAPI.Models
{
    public class Coupon
    {
        [Key]
        public int CouponId { get; set; }
        [Required]
        public string CouponCode { get; set; }
        [Required]

        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }  
    }
}
