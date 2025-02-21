using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Blog.MVC.Models;
using Blog.Data.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;

namespace Blog.MVC.Areas.Controllers;

[Area(areaName:"Admin")]
public class HomeController : Controller
{

private readonly ProgrammersBlogContext _context;

public HomeController(ProgrammersBlogContext context)
{
    _context = context;
}
      public async Task<IActionResult> Index()
        {
            var articles = await _context.Articles.ToListAsync();
            return View(articles);
        }


    
}
