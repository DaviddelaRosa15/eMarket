using eMarket.Core.Application.ViewModels.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.Core.Application.Interfaces.Services
{
    public interface IArticleService : IGenericService<SaveArticleViewModel, ArticleViewModel>
    {
        Task<List<ArticleViewModel>> GetAllViewModelWithFilters(FilterArticleViewModel filters);
        Task<List<DetailsViewModel>> GetByIdDetailsViewModel(int id);
    }
}
