using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Blog.MVC.Models;
using ProgrammersBlog.Services.Abstract;
using Blog.Shared.Utilities.Results.ComplexTypes;


namespace Blog.MVC.Areas.Controllers;

[Area("Admin")]
public class CategoryController : Controller
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public async Task<IActionResult> Index()
    {
        var result = await _categoryService.GetAll();

       
            return View(result.Data);
        

    }
}




