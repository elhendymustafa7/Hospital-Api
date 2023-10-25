using Hospital_Api.Model;

namespace Hospital_Api.Model
{
    public class on_call
    {
        public int NurseID { get; set; }
        public int BlockFloorID { get; set; }
        public int BlockCodeID { get; set; }
        public TimeOnly OnCallStart { get; set; }
        public TimeOnly OnCallEnd { get; set; }
        public Nurse nurse { get; set; }
        public Block block { get; set; }
    }
}