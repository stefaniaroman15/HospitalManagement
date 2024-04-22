namespace HospitalManagement.Core.Dtos.Response
{
    public class PatientResponseDto
    {
        public int PatientId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public DateTime AdmissionDate { get; set; }

        public DateTime DischargeDate { get; set; }

        public List<MedicalHistoryResponseDto> MedicalHistories { get; set; }
    }
}
