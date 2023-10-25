namespace Hospital_Api.Model
{
    public class trained_in
    {
        public int DoctorID { get; set; }
        public int ProcedureID { get; set; }
        public DateTime CertificationDate { get; set; }
        public DateTime CertificationExpires { get; set; }
        public Doctor Doctor { get; set; }
        public Procedure Procedure { get; set; }

    }
}
