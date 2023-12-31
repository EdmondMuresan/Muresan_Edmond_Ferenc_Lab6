﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Muresan_Edmond_Ferenc_Lab2.Data;
using Muresan_Edmond_Ferenc_Lab2.Models;

namespace Muresan_Edmond_Ferenc_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Muresan_Edmond_Ferenc_Lab2.Data.Muresan_Edmond_Ferenc_Lab2Context _context;

        public IndexModel(Muresan_Edmond_Ferenc_Lab2.Data.Muresan_Edmond_Ferenc_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;
        public int CategoryID { get; set; }

        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }
    }
}
