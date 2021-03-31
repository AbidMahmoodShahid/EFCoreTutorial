using EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTutorial.Repos.FDNP_CC_Repo
{
    public class FDNP_Blogger_CC_Repo : IFDNP_Blogger_CC_Repo
    {
        private EFCoreTutorialContext _eFCoreTutorialContext;

        public FDNP_Blogger_CC_Repo(EFCoreTutorialContext eFCoreTutorialContext)
        {
            _eFCoreTutorialContext = eFCoreTutorialContext;
        }

        public async Task Attach(FDNP_Blogger_CC fDNP_Blogger_CC)
        {
            _eFCoreTutorialContext.FDNP_Blogger_CC.Attach(fDNP_Blogger_CC);
        }

        public async Task AttachRange(List<FDNP_Blogger_CC> fDNP_Blogger_CCList)
        {
            _eFCoreTutorialContext.FDNP_Blogger_CC.AttachRange(fDNP_Blogger_CCList);
        }

        public async Task Delete(FDNP_Blogger_CC fDNP_Blogger_CC)
        {
            _eFCoreTutorialContext.FDNP_Blogger_CC.Remove(fDNP_Blogger_CC);
        }

        public async Task<List<FDNP_Blogger_CC>> GetAll()
        {
            return _eFCoreTutorialContext.FDNP_Blogger_CC.ToList();
        }

        public async Task Update(FDNP_Blogger_CC fDNP_Blogger_CC)
        {
            _eFCoreTutorialContext.FDNP_Blogger_CC.Update(fDNP_Blogger_CC);
        }

        public async Task UpdateRange(List<FDNP_Blogger_CC> fDNP_Blogger_CCList)
        {
            _eFCoreTutorialContext.FDNP_Blogger_CC.UpdateRange(fDNP_Blogger_CCList);
        }
    }
}
