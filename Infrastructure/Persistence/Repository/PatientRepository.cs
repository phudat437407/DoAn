using ApplicationCore.Interfaces;
using ApplicationCore.Entities;

namespace Infrastructure.Persistence.Repository
{
    public class PatientRepository : EFRepository<Patient>, IPatientRepository
    {
        public PatientRepository(RegisterContext context) : base(context)
        {
            
        }

         /*public IEnumerable<string> GetPatientName()
        {
            return Context.Patients
                            .Select(m => m.PatientName)
                            .Distinct().ToList();
        }*/

        //protected new PatientContext Context => Context as PatientContext;
    }
}