using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VehicleServiceBookingApplication.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int ServiceTypeId { get; set; }

        [Required]
        public int StoreId { get; set; }

        [Required]
        [StringLength(100)]
        public string VehicleDetails { get; set; }

        [Required]
        public int Quantity { get; set; } = 1;

        [Required]
        public DateTime AddedAt { get; set; } = DateTime.UtcNow;

        // Foreign Key Relationships
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("ServiceTypeId")]
        public virtual ServiceType ServiceType { get; set; }

    }
}
