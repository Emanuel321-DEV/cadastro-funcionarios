using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using cadastro_funcionarios.Data;
using cadastro_funcionarios.Models;

namespace cadastro_funcionarios.Pages.Addresses
{
    public class EditModel : PageModel
    {
        private readonly cadastro_funcionarios.Data.MyDbContext _context;

        public EditModel(cadastro_funcionarios.Data.MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Address Address { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Address == null)
            {
                return NotFound();
            }

            var address =  await _context.Address.FirstOrDefaultAsync(m => m.Id == id);
            if (address == null)
            {
                return NotFound();
            }
            Address = address;
           ViewData["EmployeeForeignKey"] = new SelectList(_context.Employee, "Id", "Name");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Address).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AddressExists(Address.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AddressExists(int id)
        {
          return _context.Address.Any(e => e.Id == id);
        }
    }
}
