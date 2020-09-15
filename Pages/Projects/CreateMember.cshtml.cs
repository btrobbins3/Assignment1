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
    public class CreateMemberModel : PageModel
    {
        private readonly Assignment1.Models.Assignment1DbContext _context;

        public CreateMemberModel(Assignment1.Models.Assignment1DbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["TeamId"] = new SelectList(_context.Teams, "TeamId", "teamName");
            return Page();
        }

        [BindProperty]
        public Member Member { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Members.Add(Member);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Members");
        }
    }
}
