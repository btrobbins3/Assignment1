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
    public class CreateClientModel : PageModel
    {
        private readonly Assignment1.Models.Assignment1DbContext _context;

        public CreateClientModel(Assignment1.Models.Assignment1DbContext context)
        {
            _context = context;
        }

        // public IActionResult OnGet()
        // {
        // ViewData["ClientId"] = new SelectList(_context.Clients, "ClientId", "fName");
        // ViewData["TeamId"] = new SelectList(_context.Teams, "TeamId", "teamName");
        //     return Page();
        // }

        [BindProperty]
        public Client Client { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Clients.Add(Client);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Create");
        }
    }
}
