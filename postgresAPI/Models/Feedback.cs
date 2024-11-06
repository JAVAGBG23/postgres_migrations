using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace postgresAPI.Models
{
    public class Feedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Appointment")]
        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public User Patient { get; set; }

        public string Comment { get; set; }
    }
}

