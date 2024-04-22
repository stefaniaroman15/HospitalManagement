namespace HospitalManagement.Database.Entities
{
    public class MedicalHistory
    {
        public int HistoryId { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string Doctor { get; set; }
        public int PatientId { get; set; } // Cheia externă către pacient

        // Proprietate de navigare către pacientul asociat
        public virtual Patient Patient { get; set; }
    }
}
