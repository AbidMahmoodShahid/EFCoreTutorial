using EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTutorial.Repos.FDNP_CC_Repo
{
    public class FDNP_Post_CC_Repo : IFDNP_Post_CC_Repo
    {
        private EFCoreTutorialContext _eFCoreTutorialContext;

        public FDNP_Post_CC_Repo(EFCoreTutorialContext eFCoreTutorialContext)
        {
            _eFCoreTutorialContext = eFCoreTutorialContext;
        }

        public async Task Attach(FDNP_Post_CC fDNP_Post_CC)
        {
            _eFCoreTutorialContext.FDNP_Post_CC.Attach(fDNP_Post_CC);
        }

        public async Task AttachRange(List<FDNP_Post_CC> fDNP_Post_CCList)
        {
            _eFCoreTutorialContext.FDNP_Post_CC.AttachRange(fDNP_Post_CCList);
        }

        public async Task Delete(FDNP_Post_CC fDNP_Post_CC)
        {
            _eFCoreTutorialContext.FDNP_Post_CC.Remove(fDNP_Post_CC);
        }

        public async Task<List<FDNP_Post_CC>> GetAll()
        {
            return _eFCoreTutorialContext.FDNP_Post_CC.Include(post => post.TagList).ToList();
        }

        public async Task Update(FDNP_Post_CC fDNP_Post_CC)
        {
            _eFCoreTutorialContext.FDNP_Post_CC.Update(fDNP_Post_CC);
        }

        public async Task UpdateRange(List<FDNP_Post_CC> fDNP_Post_CCList)
        {
            _eFCoreTutorialContext.FDNP_Post_CC.UpdateRange(fDNP_Post_CCList);
        }
    }
}
