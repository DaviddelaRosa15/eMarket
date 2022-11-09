using Microsoft.EntityFrameworkCore;
using eMarket.Core.Application.Interfaces.Repositories;
using eMarket.Core.Domain.Entitties;
using eMarket.Infrastructure.Persistence.Contexts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eMarket.Infrastructure.Persistence.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly ApplicationContext _dbContext;

        public CategoryRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

      
    }
}
