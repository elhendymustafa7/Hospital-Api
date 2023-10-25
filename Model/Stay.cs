
namespace Hospital_Api.Model
{
    public class Stay
    {
        public int Id { get; set; }
        public int PatientID { get; set; }
        public int RoomId { get; set; }
        public TimeOnly Start { get; set; }
        public TimeOnly End { get; set; }
        public Patient patient { get; set; }
        public Room room { get; set; }

    }
}
