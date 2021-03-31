using EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCoreTutorial.Repos.FDNP_CC_Repo
{
    public interface IFDNP_Address_CC_Repo
    {
        Task<List<FDNP_Address_CC>> GetAll();

        Task Attach(FDNP_Address_CC fDNP_Address_CC);

        Task AttachRange(List<FDNP_Address_CC> fDNP_Address_CCList);

        Task Update(FDNP_Address_CC fDNP_Address_CC);

        Task UpdateRange(List<FDNP_Address_CC> fDNP_Address_CCList);

        Task Delete(FDNP_Address_CC fDNP_Address_CC);
    }
}
