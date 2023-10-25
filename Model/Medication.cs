namespace Hospital_Api.Model
{
    public class Medication
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public List<Prescribe> prescribes { get; set; }

    }
}
