namespace Hospital_Api.Model
{
    public class Nurse
    {
        public int NurseID { get; set; }
        public int SSN { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public bool Registered { get; set; }
        public List<Appointment> appointments { get; set; }
        public List<on_call> on_Calls { get; set; }

    }
}
