using eMarket.Core.Application.ViewModels.User;
using System.Threading.Tasks;

namespace eMarket.Core.Application.Interfaces.Services
{
    public interface IUserService : IGenericService<SaveUserViewModel, UserViewModel>
    {
        Task<UserViewModel> Login(LoginViewModel vm);
        Task<bool> UserNameValidation(string userName);
    }
}
