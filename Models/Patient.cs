namespace Medlatec.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
