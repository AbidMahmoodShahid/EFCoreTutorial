using EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTutorial.Repos.FDNP_CC_Repo
{
    public class FDNP_Point_CC_Repo : IFDNP_Point_CC_Repo
    {
        private EFCoreTutorialContext _eFCoreTutorialContext;

        public FDNP_Point_CC_Repo(EFCoreTutorialContext eFCoreTutorialContext)
        {
            _eFCoreTutorialContext = eFCoreTutorialContext;
        }

        public async Task Attach(FDNP_Point_CC fDNP_Point_CC)
        {
            _eFCoreTutorialContext.FDNP_Point_CC.Attach(fDNP_Point_CC);
        }

        public async Task AttachRange(List<FDNP_Point_CC> fDNP_Point_CCList)
        {
            _eFCoreTutorialContext.FDNP_Point_CC.AttachRange(fDNP_Point_CCList);
        }

        public async Task Delete(FDNP_Point_CC fDNP_Point_CC)
        {
            _eFCoreTutorialContext.FDNP_Point_CC.Remove(fDNP_Point_CC);
        }

        public async Task<List<FDNP_Point_CC>> GetAll()
        {
            return _eFCoreTutorialContext.FDNP_Point_CC.ToList();
        }

        public async Task Update(FDNP_Point_CC fDNP_Point_CC)
        {
            _eFCoreTutorialContext.FDNP_Point_CC.Update(fDNP_Point_CC);
        }

        public async Task UpdateRange(List<FDNP_Point_CC> fDNP_Point_CCList)
        {
            _eFCoreTutorialContext.FDNP_Point_CC.UpdateRange(fDNP_Point_CCList);
        }
    }
}
