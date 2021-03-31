using EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCoreTutorial.Repos.FDNP_CC_Repo
{
    public interface IFDNP_Tag_CC_Repo
    {
        Task<List<FDNP_Tag_CC>> GetAll();

        Task Attach(FDNP_Tag_CC fDNP_Tag_CC);

        Task AttachRange(List<FDNP_Tag_CC> fDNP_Tag_CCList);

        Task Update(FDNP_Tag_CC fDNP_Tag_CC);

        Task UpdateRange(List<FDNP_Tag_CC> fDNP_Tag_CCList);

        Task Delete(FDNP_Tag_CC fDNP_Tag_CC);
    }
}
