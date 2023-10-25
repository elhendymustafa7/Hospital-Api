namespace Hospital_Api.Model
{
    public class Prescribe
    {
        public int DoctorID { get; set; }
        public int PatientID { get; set; }
        public int MedicationID { get; set; }
        public int AppointmentID { get; set; }
        public string Dose { get; set; }
        public TimeOnly Date { get; set; }
        public Doctor doctor { get; set; }
        public Medication medication { get; set; }
        public Patient patient { get; set; }
        public Appointment appointment { get; set; }

    }
}