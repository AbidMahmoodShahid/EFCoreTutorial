using EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTutorial.Repos.FDNP_CC_Repo
{
    public class FDNP_Blog_CC_Repo : IFDNP_Blog_CC_Repo
    {
        private EFCoreTutorialContext _eFCoreTutorialContext;

        public FDNP_Blog_CC_Repo(EFCoreTutorialContext eFCoreTutorialContext)
        {
            _eFCoreTutorialContext = eFCoreTutorialContext;
        }

        public async Task Attach(FDNP_Blog_CC fDNP_Blog_CC)
        {
            _eFCoreTutorialContext.FDNP_Blog_CC.Attach(fDNP_Blog_CC);
        }

        public async Task AttachRange(List<FDNP_Blog_CC> fDNP_Blog_CCList)
        {
            _eFCoreTutorialContext.FDNP_Blog_CC.AttachRange(fDNP_Blog_CCList);
        }

        public async Task Delete(FDNP_Blog_CC fDNP_Blog_CC)
        {
            _eFCoreTutorialContext.FDNP_Blog_CC.Remove(fDNP_Blog_CC);
        }

        public async Task<List<FDNP_Blog_CC>> GetAll()
        {
            return _eFCoreTutorialContext.FDNP_Blog_CC.Include(blog => blog.PostList).ToList();
        }

        public async Task Update(FDNP_Blog_CC fDNP_Blog_CC)
        {
            _eFCoreTutorialContext.FDNP_Blog_CC.Update(fDNP_Blog_CC);
        }

        public async Task UpdateRange(List<FDNP_Blog_CC> fDNP_Blog_CCList)
        {
            _eFCoreTutorialContext.FDNP_Blog_CC.UpdateRange(fDNP_Blog_CCList);
        }
    }
}
