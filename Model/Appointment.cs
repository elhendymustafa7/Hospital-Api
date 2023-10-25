
namespace Hospital_Api.Model
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int PreNurseID { get; set; }
        public int DoctorID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string ExaminationRoom { get; set; }

        public Patient Patient { get; set; }
        public Nurse nurse { get; set; }
        public Doctor doctor { get; set; }
        public List<Prescribe> prescribes { get; set; }

    }
}
