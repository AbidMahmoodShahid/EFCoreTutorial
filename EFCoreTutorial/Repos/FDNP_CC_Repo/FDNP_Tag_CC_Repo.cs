using EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTutorial.Repos.FDNP_CC_Repo
{
    public class FDNP_Tag_CC_Repo : IFDNP_Tag_CC_Repo
    {
        private EFCoreTutorialContext _eFCoreTutorialContext;

        public FDNP_Tag_CC_Repo(EFCoreTutorialContext eFCoreTutorialContext)
        {
            _eFCoreTutorialContext = eFCoreTutorialContext;
        }

        public async Task Attach(FDNP_Tag_CC fDNP_Tag_CC)
        {
            _eFCoreTutorialContext.FDNP_Tag_CC.Attach(fDNP_Tag_CC);
        }

        public async Task AttachRange(List<FDNP_Tag_CC> fDNP_Tag_CCList)
        {
            _eFCoreTutorialContext.FDNP_Tag_CC.AttachRange(fDNP_Tag_CCList);
        }

        public async Task Delete(FDNP_Tag_CC fDNP_Tag_CC)
        {
            _eFCoreTutorialContext.FDNP_Tag_CC.Remove(fDNP_Tag_CC);
        }

        public async Task<List<FDNP_Tag_CC>> GetAll()
        {
            return _eFCoreTutorialContext.FDNP_Tag_CC.Include(tag => tag.PostList).ToList();
        }

        public async Task Update(FDNP_Tag_CC fDNP_Tag_CC)
        {
            _eFCoreTutorialContext.FDNP_Tag_CC.Update(fDNP_Tag_CC);
        }

        public async Task UpdateRange(List<FDNP_Tag_CC> fDNP_Tag_CCList)
        {
            _eFCoreTutorialContext.FDNP_Tag_CC.UpdateRange(fDNP_Tag_CCList);
        }
    }
}
