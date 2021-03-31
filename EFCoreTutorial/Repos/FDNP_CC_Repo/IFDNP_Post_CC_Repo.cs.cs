using EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCoreTutorial.Repos.FDNP_CC_Repo
{
    public interface IFDNP_Post_CC_Repo
    {
        Task<List<FDNP_Post_CC>> GetAll();

        Task Attach(FDNP_Post_CC fDNP_Post_CC);

        Task AttachRange(List<FDNP_Post_CC> fDNP_Post_CCList);

        Task Update(FDNP_Post_CC fDNP_Post_CC);

        Task UpdateRange(List<FDNP_Post_CC> fDNP_Post_CCList);

        Task Delete(FDNP_Post_CC fDNP_Post_CC);
    }
}
