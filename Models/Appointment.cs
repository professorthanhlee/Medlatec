namespace Medlatec.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string DoctorName { get; set; }
        public string Status { get; set; } 

        public virtual Patient Patient { get; set; }
    }
}
