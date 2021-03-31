using EFCoreTutorial;
using EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDNP_CC_Repository
{
    public class FDNP_Address_CC_Repo : IFDNP_Address_CC_Repo
    {
        private EFCoreTutorialContext _eFCoreTutorialContext;

        public FDNP_Address_CC_Repo(EFCoreTutorialContext eFCoreTutorialContext)
        {
            _eFCoreTutorialContext = eFCoreTutorialContext;
        }

        public async Task Attach(FDNP_Address_CC fDNP_Address_CC)
        {
            _eFCoreTutorialContext.FDNP_Address_CC.Attach(fDNP_Address_CC);
        }

        public async Task AttachRange(List<FDNP_Address_CC> fDNP_Address_CCList)
        {
            _eFCoreTutorialContext.FDNP_Address_CC.AttachRange(fDNP_Address_CCList);
        }

        public async Task Delete(FDNP_Address_CC fDNP_Address_CC)
        {
            _eFCoreTutorialContext.FDNP_Address_CC.Remove(fDNP_Address_CC);
        }

        public async Task<List<FDNP_Address_CC>> GetAll()
        {
            return _eFCoreTutorialContext.FDNP_Address_CC.ToList();
        }

        public async Task Update(FDNP_Address_CC fDNP_Address_CC)
        {
            _eFCoreTutorialContext.FDNP_Address_CC.Update(fDNP_Address_CC);
        }

        public async Task UpdateRange(List<FDNP_Address_CC> fDNP_Address_CCList)
        {
            _eFCoreTutorialContext.FDNP_Address_CC.UpdateRange(fDNP_Address_CCList);
        }
    }
}
