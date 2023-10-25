namespace Hospital_Api.Model
{
    public class Block
    {
        public int BlockFloorID { get; set; }
        public int BlockCodeID { get; set; }
        public List<Room> rooms { get; set; }
        public List<on_call> on_Calls { get; set; }
    }
}
