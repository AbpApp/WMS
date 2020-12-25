using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Hd.Container.Samples
{
    public interface ISampleAppService : IApplicationService
    {
        Task<SampleDto> GetAsync();

        Task<SampleDto> GetAuthorizedAsync();
    }
}
