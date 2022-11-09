using eMarket.Core.Application.Interfaces.Services;
using eMarket.Core.Application.ViewModels.Articles;
using eMarket.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using eMarket.WebApp.Middlewares;

namespace eMarket.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly ValidateUserSession _validateUserSession;

        public HomeController(IArticleService articleService, ICategoryService categoryService, ValidateUserSession validateUserSession)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _validateUserSession = validateUserSession;
        }

        public async Task<IActionResult> Index(FilterArticleViewModel vm)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            ViewBag.Categories = await _categoryService.GetAllViewModel();
            return View(await _articleService.GetAllViewModelWithFilters(vm));
        }

        public async Task<IActionResult> Details(int id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            return View(await _articleService.GetByIdDetailsViewModel(id));
        }
    }
}
