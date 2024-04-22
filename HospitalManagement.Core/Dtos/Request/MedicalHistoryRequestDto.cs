namespace HospitalManagement.Core.Dtos.Request
{
    public class MedicalHistoryRequestDto
    {
        public string Diagnosis { get; set; }

        public string Treatment { get; set; }

        public string Doctor { get; set; }

        public int PatientId { get; set; } // ID-ul pacientului asociat cu istoricul medical
    }
}
