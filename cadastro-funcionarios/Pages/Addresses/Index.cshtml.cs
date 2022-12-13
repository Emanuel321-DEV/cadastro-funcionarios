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
    public class IndexModel : PageModel
    {
        private readonly cadastro_funcionarios.Data.MyDbContext _context;

        public IndexModel(cadastro_funcionarios.Data.MyDbContext context)
        {
            _context = context;
        }

        public IList<Address> Address { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Address != null)
            {
                Address = await _context.Address
                .Include(a => a.Employee).ToListAsync();
            }
        }
    }
}
