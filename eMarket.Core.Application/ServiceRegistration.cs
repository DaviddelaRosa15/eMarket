using Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using eMarket.Core.Application.Interfaces.Services;

namespace eMarket.Core.Application
{

    //Extension Method - Decorator
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {   
            #region Services
            services.AddTransient<IArticleService, ArticleService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IUserService, UserService>();
            #endregion
        }
    }
}
