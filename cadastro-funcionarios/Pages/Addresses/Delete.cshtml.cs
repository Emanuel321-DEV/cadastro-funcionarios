using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using cadastro_funcionarios.Data;
using cadastro_funcionarios.Models;

namespace cadastro_funcionarios.Pages.Addresses
{
    public class DeleteModel : PageModel
    {
        private readonly cadastro_funcionarios.Data.MyDbContext _context;

        public DeleteModel(cadastro_funcionarios.Data.MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Address Address { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Address == null)
            {
                return NotFound();
            }

            var address = await _context.Address.FirstOrDefaultAsync(m => m.Id == id);

            if (address == null)
            {
                return NotFound();
            }
            else 
            {
                Address = address;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Address == null)
            {
                return NotFound();
            }
            var address = await _context.Address.FindAsync(id);

            if (address != null)
            {
                Address = address;
                _context.Address.Remove(Address);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
