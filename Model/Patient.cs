
namespace Hospital_Api.Model
{
    public class Patient
    {
        public int SSN { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public int InsuranceID { get; set; }


        public int DoctorID { get; set; }


        public Doctor Doctor { get; set; }
        public List<Stay> staies { get; set; }
        public List<Appointment> appointments { get; set; }
        public List<Prescribe> prescribes { get; set; }


    }
}
