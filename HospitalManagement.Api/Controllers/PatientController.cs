using HospitalManagement.Core.Services;
using Microsoft.AspNetCore.Mvc;
using HospitalManagement.Core.Dtos.Response;
using HospitalManagement.Core.Dtos.Request;
using Microsoft.AspNetCore.Http;

namespace HospitalManagement.Api.Controllers
{
    [Route("api/Patients")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<PatientResponseDto>> GetPatients()
        {
            return Ok(_patientService.GetPatients());
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<int> CreatePatient([FromBody] PatientRequestDto patient)
        {
            int id = _patientService.CreatePatient(patient);
            return StatusCode(StatusCodes.Status201Created, id);
        }
    }
}
