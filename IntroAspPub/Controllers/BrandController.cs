﻿using IntroAspPub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroAspPub.Controllers
{
    public class BrandController : Controller
    {
        private readonly PubContext _context;

        public BrandController(PubContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Brands.ToListAsync());
        }
    }
}
