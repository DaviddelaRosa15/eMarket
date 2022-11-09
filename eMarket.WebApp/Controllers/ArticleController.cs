using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using eMarket.Core.Application.Interfaces.Services;
using eMarket.Core.Application.ViewModels.Articles;
using System;
using System.IO;
using System.Threading.Tasks;
using eMarket.WebApp.Middlewares;

namespace eMarket.WebApp.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly ValidateUserSession _validateUserSession;

        public ArticleController(IArticleService articleService, ICategoryService categoryService, ValidateUserSession validateUserSession)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _validateUserSession = validateUserSession;
        }
        public async Task<IActionResult> Index()
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }
            return View(await _articleService.GetAllViewModel());
        }

        public async Task<IActionResult> Create()
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }
            SaveArticleViewModel vm = new();
            vm.Categories = await _categoryService.GetAllViewModel();
            return View("SaveArticle", vm);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaveArticleViewModel vm)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            if (!ModelState.IsValid)
            {
                vm.Categories = await _categoryService.GetAllViewModel();
                return View("SaveArticle", vm);
            }

            SaveArticleViewModel articleVm = await _articleService.Add(vm);

            if (articleVm.Id != 0 && articleVm != null)
            {
                articleVm.ImageUrlOne = UploadFile(vm.ImageOne, articleVm.Id);
                articleVm.ImageUrlTwo = UploadFile(vm.ImageTwo, articleVm.Id);
                articleVm.ImageUrlThree = UploadFile(vm.ImageThree, articleVm.Id);
                articleVm.ImageUrlFour = UploadFile(vm.ImageFour, articleVm.Id);

                await _articleService.Update(articleVm);
            }

            return RedirectToRoute(new { controller = "Article", action = "Index" });
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            SaveArticleViewModel vm = await _articleService.GetByIdSaveViewModel(id);
            vm.Categories = await _categoryService.GetAllViewModel();
            return View("SaveArticle", vm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SaveArticleViewModel vm)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            if (!ModelState.IsValid)
            {
                vm.Categories = await _categoryService.GetAllViewModel();
                return View("SaveArticle", vm);
            }

            SaveArticleViewModel articleVm = await _articleService.GetByIdSaveViewModel(vm.Id);
            vm.ImageUrlOne = UploadFile(vm.ImageOne, vm.Id, true, articleVm.ImageUrlOne);
            vm.ImageUrlTwo = UploadFile(vm.ImageTwo, vm.Id, true, articleVm.ImageUrlTwo);
            vm.ImageUrlThree = UploadFile(vm.ImageThree, vm.Id, true, articleVm.ImageUrlThree);
            vm.ImageUrlFour = UploadFile(vm.ImageFour, vm.Id, true, articleVm.ImageUrlFour);
            await _articleService.Update(vm);
            return RedirectToRoute(new { controller = "Article", action = "Index" });
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            return View(await _articleService.GetByIdSaveViewModel(id));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            await _articleService.Delete(id);

            string basePath = $"/Images/Articles/{id}";
            string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot{basePath}");

            if (Directory.Exists(path))
            {
                DirectoryInfo directory = new(path);

                foreach (FileInfo file in directory.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo folder in directory.GetDirectories())
                {
                    folder.Delete(true);
                }

                Directory.Delete(path);
            }

            return RedirectToRoute(new { controller = "Article", action = "Index" });
        }

        private string UploadFile(IFormFile file, int id, bool isEditMode = false, string imagePath = "")
        {
            if (isEditMode)
            {
                if (file == null)
                {
                    return imagePath;
                }
            }
            string basePath = $"/Images/Articles/{id}";
            string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot{basePath}");

            //create folder if not exist
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            //get file extension
            if (file != null)
            {
                Guid guid = Guid.NewGuid();
                FileInfo fileInfo = new(file.FileName);
                string fileName = guid + fileInfo.Extension;

                string fileNameWithPath = Path.Combine(path, fileName);

                using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                if (isEditMode)
                {
                    if (imagePath != null)                    
                    {
                        string[] oldImagePart = imagePath.Split("/");
                        string oldImagePath = oldImagePart[^1];
                        string completeImageOldPath = Path.Combine(path, oldImagePath);

                        if (System.IO.File.Exists(completeImageOldPath))
                        {
                            System.IO.File.Delete(completeImageOldPath);
                        }
                    }

                }
                return $"{basePath}/{fileName}";
            }
            return null;
        }
    }
}
