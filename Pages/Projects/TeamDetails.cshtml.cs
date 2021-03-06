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
    public class TeamDetailsModel : PageModel
    {
        private readonly Assignment1.Models.Assignment1DbContext _context;

        public TeamDetailsModel(Assignment1.Models.Assignment1DbContext context)
        {
            _context = context;
        }

        public Team Team { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Team = await _context.Teams
                .Include(t => t.Members)
                .Include(t => t.Projects).FirstOrDefaultAsync(m => m.TeamId == id);

            if (Team == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
