using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Assignment1.Models;

namespace Assignment1.Pages.Projects
{
    public class DetailsModel : PageModel
    {
        private readonly Assignment1.Models.Assignment1DbContext _context;

        public DetailsModel(Assignment1.Models.Assignment1DbContext context)
        {
            _context = context;
        }

        public Project Project { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Project = await _context.Projects
                .Include(p => p.Client)
                .Include(p => p.Team).FirstOrDefaultAsync(m => m.ProjectId == id);

            if (Project == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
