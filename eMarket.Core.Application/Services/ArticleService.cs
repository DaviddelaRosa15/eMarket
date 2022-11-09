using Microsoft.AspNetCore.Http;
using eMarket.Core.Application.Interfaces.Repositories;
using eMarket.Core.Application.Interfaces.Services;
using eMarket.Core.Application.ViewModels.Articles;
using eMarket.Core.Application.ViewModels.User;
using eMarket.Core.Domain.Entitties;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMarket.Core.Application.Helpers;

namespace Application.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserViewModel userViewModel;
        private List<ArticleViewModel> filterList = new();

        public ArticleService(IArticleRepository articleRepository, IHttpContextAccessor httpContextAccessor)
        {
            _articleRepository = articleRepository;
            _httpContextAccessor = httpContextAccessor;
            userViewModel = _httpContextAccessor.HttpContext.Session.Get<UserViewModel>("user");
        }

        public async Task Update(SaveArticleViewModel vm)
        {
            Article article = await _articleRepository.GetByIdAsync(vm.Id);
            article.Id = vm.Id;
            article.Name = vm.Name;
            article.Price = vm.Price;
            article.ImageUrlOne = vm.ImageUrlOne;
            article.ImageUrlTwo = vm.ImageUrlTwo;
            article.ImageUrlThree = vm.ImageUrlThree;
            article.ImageUrlFour = vm.ImageUrlFour;
            article.Description = vm.Description;
            article.CategoryId = vm.CategoryId;

            await _articleRepository.UpdateAsync(article);
        }

        public async Task<SaveArticleViewModel> Add(SaveArticleViewModel vm)
        {
            Article article = new();
            article.Id = vm.Id;
            article.Name = vm.Name;
            article.Price = vm.Price;
            article.ImageUrlOne = vm.ImageUrlOne;
            article.ImageUrlTwo = vm.ImageUrlTwo;
            article.ImageUrlThree = vm.ImageUrlThree;
            article.ImageUrlFour = vm.ImageUrlFour;
            article.Description = vm.Description;
            article.CategoryId = vm.CategoryId;
            article.UserId = userViewModel.Id;

            article = await _articleRepository.AddAsync(article);

            SaveArticleViewModel articleVm = new();

            articleVm.Id = article.Id;
            articleVm.Name = article.Name;
            articleVm.Price = article.Price;
            articleVm.ImageUrlOne = article.ImageUrlOne;
            articleVm.ImageUrlTwo = article.ImageUrlTwo;
            articleVm.ImageUrlThree = article.ImageUrlThree;
            articleVm.ImageUrlFour = article.ImageUrlFour;
            articleVm.Description = article.Description;
            articleVm.CategoryId = article.CategoryId;

            return articleVm;
        }

        public async Task Delete(int id)
        {
            var article = await _articleRepository.GetByIdAsync(id);
            await _articleRepository.DeleteAsync(article);
        }

        public async Task<SaveArticleViewModel> GetByIdSaveViewModel(int id)
        {
            var article = await _articleRepository.GetByIdAsync(id);

            SaveArticleViewModel vm = new();
            vm.Id = article.Id;
            vm.Name = article.Name;
            vm.Price = article.Price;
            vm.ImageUrlOne = article.ImageUrlOne;
            vm.ImageUrlTwo = article.ImageUrlTwo;
            vm.ImageUrlThree = article.ImageUrlThree;
            vm.ImageUrlFour = article.ImageUrlFour;
            vm.Description = article.Description;
            vm.CategoryId = article.CategoryId;

            return vm;
        }

        public async Task<List<DetailsViewModel>> GetByIdDetailsViewModel(int id)
        {
            var article = await _articleRepository.GetAllWithIncludeAsync(new List<string> { "Category", "User"});

            return article.Where(article => article.Id == id).Select(article => new DetailsViewModel
            {
                Name = article.Name,
                Description = article.Description,
                Id = article.Id,
                Price = article.Price,
                ImageUrlOne = article.ImageUrlOne,
                ImageUrlTwo = article.ImageUrlTwo,
                ImageUrlThree = article.ImageUrlThree,
                ImageUrlFour = article.ImageUrlFour,
                CategoryName = article.Category.Name,
                NameUser = article.User.Name + " " + article.User.LastName,
                EmailUser = article.User.Email,
                PhoneUser = article.User.Phone,
                PublicationDate = article.Created
            }).ToList();
        }

        public async Task<List<ArticleViewModel>> GetAllViewModel()
        {
            var articleList = await _articleRepository.GetAllWithIncludeAsync(new List<string> { "Category" });

            return articleList.Where(article => article.UserId == userViewModel.Id).Select(article => new ArticleViewModel
            {
                Name = article.Name,
                Description = article.Description,
                Id = article.Id,
                Price = article.Price,
                ImageUrlOne = article.ImageUrlOne,
                ImageUrlTwo = article.ImageUrlTwo,
                ImageUrlThree = article.ImageUrlThree,
                ImageUrlFour = article.ImageUrlFour,
                CategoryName = article.Category.Name,
                CategoryId = article.Category.Id
            }).OrderBy(article => article.Name).ToList();
        }

        public async Task<List<ArticleViewModel>> GetAllViewModelWithFilters(FilterArticleViewModel filters)
        {
            var articleList = await _articleRepository.GetAllWithIncludeAsync(new List<string> { "Category" });
            
            var listViewModels = articleList.Where(article => article.UserId != userViewModel.Id).Select(article => new ArticleViewModel
            {
                Name = article.Name,
                Description = article.Description,
                Id = article.Id,
                Price = article.Price,
                ImageUrlOne = article.ImageUrlOne,
                ImageUrlTwo = article.ImageUrlTwo,
                ImageUrlThree = article.ImageUrlThree,
                ImageUrlFour = article.ImageUrlFour,
                CategoryName = article.Category.Name,
                CategoryId = article.Category.Id
            }).ToList();

            if (filters.CategoryId != null)
            {
                foreach (int item in filters.CategoryId)
                {
                    var filterListViewModels = articleList.Where(article => article.UserId != userViewModel.Id).Select(article => new ArticleViewModel
                    {
                        Name = article.Name,
                        Description = article.Description,
                        Id = article.Id,
                        Price = article.Price,
                        ImageUrlOne = article.ImageUrlOne,
                        ImageUrlTwo = article.ImageUrlTwo,
                        ImageUrlThree = article.ImageUrlThree,
                        ImageUrlFour = article.ImageUrlFour,
                        CategoryName = article.Category.Name,
                        CategoryId = article.Category.Id
                    }).ToList();

                    filterListViewModels = filterListViewModels.Where(article => article.CategoryId == item).ToList();

                    foreach (ArticleViewModel article in filterListViewModels)
                    {
                        filterList.Add(new ArticleViewModel() {
                            Name = article.Name,
                            Description = article.Description,
                            Id = article.Id,
                            Price = article.Price,
                            ImageUrlOne = article.ImageUrlOne,
                            ImageUrlTwo = article.ImageUrlTwo,
                            ImageUrlThree = article.ImageUrlThree,
                            ImageUrlFour = article.ImageUrlFour,
                            CategoryName = article.CategoryName,
                            CategoryId = article.CategoryId
                        });
                    }
                    
                }
                if (filters.CategoryId[0] == 0)
                {
                    listViewModels = listViewModels.OrderBy(article => article.Name).ToList();
                    return listViewModels.ToList();
                }
                else
                {
                    filterList = filterList.OrderBy(article => article.Name).ToList();
                    return filterList.ToList();
                }
            }
            else if (filters.ArticleName != null)
            {
                listViewModels = listViewModels.Where(article => article.Name.Contains(filters.ArticleName)).ToList();
            }

            listViewModels = listViewModels.OrderBy(article => article.Name).ToList();

            return listViewModels.ToList();
        }

    }
}
