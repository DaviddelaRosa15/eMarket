using Microsoft.AspNetCore.Http;
using eMarket.Core.Application.Helpers;
using eMarket.Core.Application.Interfaces.Repositories;
using eMarket.Core.Application.Interfaces.Services;
using eMarket.Core.Application.ViewModels.Categories;
using eMarket.Core.Application.ViewModels.User;
using eMarket.Core.Domain.Entitties;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IArticleRepository _articleRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserViewModel userViewModel;

        public CategoryService(ICategoryRepository categoryRepository, IArticleRepository articleRepository, IHttpContextAccessor httpContextAccessor)
        {
            _categoryRepository = categoryRepository;
            _articleRepository = articleRepository;
            _httpContextAccessor = httpContextAccessor;
            userViewModel = _httpContextAccessor.HttpContext.Session.Get<UserViewModel>("user");
        }

        public async Task Update(SaveCategoryViewModel vm)
        {
            Category category = await _categoryRepository.GetByIdAsync(vm.Id);
            category.Id = vm.Id;
            category.Name = vm.Name;
            category.Description = vm.Description;           

            await _categoryRepository.UpdateAsync(category);
        }

        public async Task<SaveCategoryViewModel> Add(SaveCategoryViewModel vm)
        {
            Category category = new();
            category.Name = vm.Name;          
            category.Description = vm.Description;           

            category = await _categoryRepository.AddAsync(category);

            SaveCategoryViewModel categoryVm = new();

            categoryVm.Id = category.Id;
            categoryVm.Name = category.Name;
            categoryVm.Description = category.Description;        

            return categoryVm;
        }

        public async Task Delete(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            await _categoryRepository.DeleteAsync(category);
        }

        public async Task<SaveCategoryViewModel> GetByIdSaveViewModel(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);

            SaveCategoryViewModel vm = new();
            vm.Id = category.Id;
            vm.Name = category.Name;
            vm.Description = category.Description;    

            return vm;
        }

        public async Task<List<CategoryViewModel>> GetAllViewModel()
        {
            var categoryList = await _categoryRepository.GetAllWithIncludeAsync(new List<string> { "Articles"});
            
            return categoryList.Select(category => new CategoryViewModel
            {
                Name = category.Name,
                Description = category.Description,
                Id = category.Id,
                ArticlesQuantity = category.Articles.Count(),                
                UsersQuantity = category.Articles.Where(a => a.CategoryId == category.Id).Select(a => a.UserId).Distinct().Count()
            }).OrderBy(category => category.Name).ToList();
        }

    }
}
