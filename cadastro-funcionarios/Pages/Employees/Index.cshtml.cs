using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using cadastro_funcionarios.Data;
using cadastro_funcionarios.Models;

namespace cadastro_funcionarios.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly cadastro_funcionarios.Data.MyDbContext _context;

        public IndexModel(cadastro_funcionarios.Data.MyDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Employee != null)
            {
                Employee = await _context.Employee.ToListAsync();
            }
        }
    }
}
