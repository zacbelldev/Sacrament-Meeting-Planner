﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Pages.NavViews.PlannerView
{
    public class IndexModel : PageModel
    {
        private readonly SacramentMeetingPlanner.Models.PlannerContext _context;

        public IndexModel(SacramentMeetingPlanner.Models.PlannerContext context)
        {
            _context = context;
        }

        public IList<Plans> Plans { get;set; }

        public async Task OnGetAsync()
        {
            Plans = await _context.Plans.ToListAsync();
        }
    }
}