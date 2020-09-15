using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Assignment1.Models;

namespace Assignment1.Pages.Projects
{
    public class CreateTeamModel : PageModel
    {
        private readonly Assignment1.Models.Assignment1DbContext _context;

        public CreateTeamModel(Assignment1.Models.Assignment1DbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Team Team { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Teams.Add(Team);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Teams");
        }
    }
}
