using EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCoreTutorial.Repos.FDNP_CC_Repo
{
    public interface IFDNP_Process_CC_Repo
    {
        Task<List<FDNP_Process_CC>> GetAll();

        Task Attach(FDNP_Process_CC fDNP_Process_CC);

        Task AttachRange(List<FDNP_Process_CC> fDNP_Process_CCList);

        Task Update(FDNP_Process_CC fDNP_Process_CC);

        Task UpdateRange(List<FDNP_Process_CC> fDNP_Process_CCList);

        Task Delete(FDNP_Process_CC fDNP_Process_CC);
    }
}
