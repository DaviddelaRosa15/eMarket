using Microsoft.EntityFrameworkCore;
using eMarket.Core.Application.Interfaces.Repositories;
using eMarket.Core.Domain.Entitties;
using eMarket.Infrastructure.Persistence.Contexts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eMarket.Infrastructure.Persistence.Repositories
{
    public class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
        private readonly ApplicationContext _dbContext;

        public ArticleRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
