using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers;

public class PieController : Controller
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IPieRepository _pieRepository;

    public PieController(ICategoryRepository categoryRepository, IPieRepository pieRepository)
    {
        _categoryRepository = categoryRepository;
        _pieRepository = pieRepository;
    }

    // GET
    public IActionResult List()
    {
        return View(_pieRepository.AllPies);
    }
}