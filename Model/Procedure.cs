namespace Hospital_Api.Model
{
    public class Procedure
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }
        public string Name { get; set; }
        public List<trained_in> trained_ins { get; set; }

    }
}
