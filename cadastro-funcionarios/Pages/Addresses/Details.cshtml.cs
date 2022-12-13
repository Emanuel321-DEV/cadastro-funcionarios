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
    public class DetailsModel : PageModel
    {
        private readonly cadastro_funcionarios.Data.MyDbContext _context;

        public DetailsModel(cadastro_funcionarios.Data.MyDbContext context)
        {
            _context = context;
        }

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
    }
}
