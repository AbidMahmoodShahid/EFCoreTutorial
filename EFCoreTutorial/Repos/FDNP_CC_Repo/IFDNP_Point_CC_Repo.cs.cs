using EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCoreTutorial.Repos.FDNP_CC_Repo
{
    public interface IFDNP_Point_CC_Repo
    {
        Task<List<FDNP_Point_CC>> GetAll();

        Task Attach(FDNP_Point_CC fDNP_Point_CC);

        Task AttachRange(List<FDNP_Point_CC> fDNP_Point_CCList);

        Task Update(FDNP_Point_CC fDNP_Point_CC);

        Task UpdateRange(List<FDNP_Point_CC> fDNP_Point_CCList);

        Task Delete(FDNP_Point_CC fDNP_Point_CC);
    }
}
