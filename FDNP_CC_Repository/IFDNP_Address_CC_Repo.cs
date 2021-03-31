using EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDNP_CC_Repository
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
