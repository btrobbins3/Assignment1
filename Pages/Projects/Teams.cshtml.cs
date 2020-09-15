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
    public class TeamsModel : PageModel
    {
        private readonly Assignment1.Models.Assignment1DbContext _context;

        public TeamsModel(Assignment1.Models.Assignment1DbContext context)
        {
            _context = context;
        }

        public IList<Team> Team { get;set; }

        public async Task OnGetAsync()
        {
            Team = await _context.Teams
                .Include(t => t.Members)
                .Include(t => t.Projects).ToListAsync();
        }
    }
}
