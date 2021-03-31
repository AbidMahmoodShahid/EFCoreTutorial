using EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCoreTutorial.Repos.FDNP_CC_Repo
{
    public interface IFDNP_Group_CC_Repo
    {
        Task<List<FDNP_Group_CC>> GetAll();

        Task Attach(FDNP_Group_CC fDNP_Group_CC);

        Task AttachRange(List<FDNP_Group_CC> fDNP_Group_CCList);

        Task Update(FDNP_Group_CC fDNP_Group_CC);

        Task UpdateRange(List<FDNP_Group_CC> fDNP_Group_CCList);

        Task Delete(FDNP_Group_CC fDNP_Group_CC);
    }
}
