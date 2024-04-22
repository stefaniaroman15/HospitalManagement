using HospitalManagement.Core.Services;
using HospitalManagement.Database.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace HospitalManagement.Core.Extensions
{
    public static class ServicesExtension
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
           

            // Adăugăm serviciile pentru pacienți
            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IPatientRepository, PatientRepository>();

            // Adăugăm serviciile pentru istoricul medical
            services.AddScoped<IMedicalHistoryService, MedicalHistoryService>();
            services.AddScoped<IMedicalHistoryRepository, MedicalHistoryRepository>();
        }
    }
}
