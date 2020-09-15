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
    public class IndexModel : PageModel
    {
        private readonly Assignment1.Models.Assignment1DbContext _context;

        public IndexModel(Assignment1.Models.Assignment1DbContext context)
        {
            _context = context;
        }

        public IList<Project> Project { get;set; }

        public async Task OnGetAsync()
        {
            Project = await _context.Projects
                .Include(p => p.Client)
                .Include(p => p.Team).ToListAsync();
        }
    }
}
