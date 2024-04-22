namespace HospitalManagement.Database.Entities
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime DischargeDate { get; set; }

        // Proprietate de navigare către istoricul medical al pacientului
        public virtual List<MedicalHistory> MedicalHistories { get; set; }
    }
}
