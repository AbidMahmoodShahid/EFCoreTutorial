using EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCoreTutorial.Repos.FDNP_CC_Repo
{
    public interface IFDNP_Blogger_CC_Repo
    {
        Task<List<FDNP_Blogger_CC>> GetAll();

        Task Attach(FDNP_Blogger_CC fDNP_Blogger_CC);

        Task AttachRange(List<FDNP_Blogger_CC> fDNP_Blogger_CCList);

        Task Update(FDNP_Blogger_CC fDNP_Blogger_CC);

        Task UpdateRange(List<FDNP_Blogger_CC> fDNP_Blogger_CCList);

        Task Delete(FDNP_Blogger_CC fDNP_Blogger_CC);
    }
}
