using EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCoreTutorial.Repos.FDNP_CC_Repo
{
    public interface IFDNP_Blog_CC_Repo
    {
        Task<List<FDNP_Blog_CC>> GetAll();

        Task Attach(FDNP_Blog_CC fDNP_Blog_CC);

        Task AttachRange(List<FDNP_Blog_CC> fDNP_Blog_CCList);

        Task Update(FDNP_Blog_CC fDNP_Blog_CC);

        Task UpdateRange(List<FDNP_Blog_CC> fDNP_Blog_CCList);

        Task Delete(FDNP_Blog_CC fDNP_Blog_CC);
    }
}
