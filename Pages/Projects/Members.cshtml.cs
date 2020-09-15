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
    public class MembersModel : PageModel
    {
        private readonly Assignment1.Models.Assignment1DbContext acontext;

        public MembersModel(Assignment1.Models.Assignment1DbContext context)
        {
            acontext = context;
        }

        public IList<Member> Member { get;set; }

        public async Task OnGetAsync()
        {
            Member = await acontext.Members
                .Include(m => m.Team).ToListAsync();
        }
    }
}
