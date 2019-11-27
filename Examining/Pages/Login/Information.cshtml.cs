using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence;
using ApplicationCore.Entities;

namespace Examining.Pages.Login
{
    public class InforModel : PageModel
    {
        private readonly RegisterContext _context;

        public InforModel(RegisterContext context)
        {
            _context = context;
        }

        public IList<Patient> Patient { get;set; }

        public async Task OnGetAsync()
        {
            Patient = await _context.Patients.ToListAsync();
        }
    }
}
