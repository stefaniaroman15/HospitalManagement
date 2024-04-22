namespace HospitalManagement.Core.Dtos.Request
{
    public class PatientRequestDto
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public DateTime AdmissionDate { get; set; }

        public DateTime DischargeDate { get; set; }
    }
}
