namespace Hospital_Api.Model
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public string Type { get; set; }
        public int BlockFloorID { get; set; }
        public int BlockCodeID { get; set; }
        public bool unavailable { get; set; }
        public Block block { get; set; }
        public List<Stay> staies { get; set; }
    }
}