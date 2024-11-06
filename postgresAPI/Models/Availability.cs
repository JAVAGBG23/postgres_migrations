using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace postgresAPI.Models
{
    public class Availability
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Caregiver")]
        public int CaregiverId { get; set; }
        public User Caregiver { get; set; }

        public ICollection<AvailableSlot> AvailableSlots { get; set; } = new List<AvailableSlot>();
    }

    public class AvailableSlot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Availability")]
        public int AvailabilityId { get; set; }
        public Availability Availability { get; set; }

        public DateTime Slot { get; set; }
    }
}

