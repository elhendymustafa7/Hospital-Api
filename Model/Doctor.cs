using Hospital_Api.Model.Enums;

namespace Hospital_Api.Model;
public class Doctor
{
    public int Id { get; set; }
    public int SSN { get; set; }
    public string Name { get; set; }
    public DoctorType DoctorType { get; set; }

    
    public int DepartmentId { get; set; }
    
    
    public Department Department { get; set; }
    public List<trained_in> trained_ins { get; set; }
    public List<Patient> Patients { get; set; }
    public List<Appointment> appointments { get; set; }
    public List<Prescribe> prescribes { get; set; }
}

