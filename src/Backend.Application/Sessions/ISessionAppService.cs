using System.Threading.Tasks;
using Abp.Application.Services;
using Backend.Sessions.Dto;

namespace Backend.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
