using ApplicationCore.Interfaces;
using ApplicationCore.Entities;

namespace ApplicationCore.Services
{
    public class PatientService : IPatientService
    {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IMapper _mapper;

        public PatientService(IUnitOfWork unitOfWork)//, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
           // _mapper = mapper;
        }

        // public IEnumerable<string> GetGenres()
        // {
        //     return _unitOfWork.Patients.GetGenres();
        // }

        public Patient GetPatient(string id)
        {
            return _unitOfWork.Patients.GetBy(id);
        }

        // public IEnumerable<PatientDto> GetPatients(int pageIndex, int pageSize, out int count)
        // {
        //     count = 4;
        //     var PatientSpecPaging = new PatientSpecification(pageIndex, pageSize);

        //     var Patients = _unitOfWork.Patients.Find(PatientSpecPaging);
        //     return _mapper.Map<IEnumerable<Patient>, IEnumerable<PatientDto>>(Patients);
        // }

        public void CreatePatient(Patient Patient)
        {
            _unitOfWork.Patients.Add(Patient);
        }

        public void DeletePatient(string id)
        {
            var Patient = _unitOfWork.Patients.GetBy(id);

            if (Patient == null) return;

            _unitOfWork.Patients.Remove(Patient);

            _unitOfWork.Complete();
        }

        public void UpdatePatient(Patient Patient)
        {
            throw new System.NotImplementedException();
        }

    }
}