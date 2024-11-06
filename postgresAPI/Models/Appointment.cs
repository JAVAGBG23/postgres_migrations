using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace postgresAPI.Models
{
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public User Patient { get; set; }

        [ForeignKey("Caregiver")]
        public int CaregiverId { get; set; }
        public User Caregiver { get; set; }

        public DateTime DateTime { get; set; }

        public AppointmentStatus Status { get; set; }
    }

    public enum AppointmentStatus
    {
        Scheduled,
        Completed,
        Cancelled
    }
}

