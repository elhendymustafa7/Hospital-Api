global using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_Api.Model
{
    public class Department
    {
        public int Id { get; set; }
        //public int Id { get; set; }
        public string Name { get; set; }
        public int Head { get; set; }
        public Doctor Doctor { get; set; }

        //public Doctor HeadDoctor { get; set; }


    }
}
