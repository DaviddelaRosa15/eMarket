using Microsoft.EntityFrameworkCore;
using eMarket.Core.Application.Helpers;
using eMarket.Core.Application.Interfaces.Repositories;
using eMarket.Core.Application.ViewModels.User;
using eMarket.Core.Domain.Entitties;
using eMarket.Infrastructure.Persistence.Contexts;
using System.Threading.Tasks;

namespace eMarket.Infrastructure.Persistence.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly ApplicationContext _dbContext;

        public UserRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override async Task<User> AddAsync(User entity)
        {
            entity.Password = PasswordEncryptation.ComputeSha256Hash(entity.Password);
            await base.AddAsync(entity);
            return entity;
        }

        public async Task<User> LoginAsync(LoginViewModel loginVm)
        {
            string passwordEncrypt = PasswordEncryptation.ComputeSha256Hash(loginVm.Password);
            User user = await _dbContext.Set<User>().FirstOrDefaultAsync(user=> user.Username == loginVm.Username && user.Password == passwordEncrypt);
            return user;
        }

        public async Task<bool> GetByNameAsync(string userName)
        {
            User user = await _dbContext.Set<User>().FirstOrDefaultAsync(user => user.Username == userName);
            if(user != null)
            {
                return true;
            }
            return false;
        }

    }
}
