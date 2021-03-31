using EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTutorial.Repos.FDNP_CC_Repo
{
    public class FDNP_Group_CC_Repo : IFDNP_Group_CC_Repo
    {
        private EFCoreTutorialContext _eFCoreTutorialContext;

        public FDNP_Group_CC_Repo(EFCoreTutorialContext eFCoreTutorialContext)
        {
            _eFCoreTutorialContext = eFCoreTutorialContext;
        }

        public async Task Attach(FDNP_Group_CC fDNP_Group_CC)
        {
            _eFCoreTutorialContext.FDNP_Group_CC.Attach(fDNP_Group_CC);
        }

        public async Task AttachRange(List<FDNP_Group_CC> fDNP_Group_CCList)
        {
            _eFCoreTutorialContext.FDNP_Group_CC.AttachRange(fDNP_Group_CCList);
        }

        public async Task Delete(FDNP_Group_CC fDNP_Group_CC)
        {
            _eFCoreTutorialContext.FDNP_Group_CC.Remove(fDNP_Group_CC);
        }

        public async Task<List<FDNP_Group_CC>> GetAll()
        {
            return _eFCoreTutorialContext.FDNP_Group_CC.Include(group => group.PointList).ToList();
        }

        public async Task Update(FDNP_Group_CC fDNP_Group_CC)
        {
            _eFCoreTutorialContext.FDNP_Group_CC.Update(fDNP_Group_CC);
        }

        public async Task UpdateRange(List<FDNP_Group_CC> fDNP_Group_CCList)
        {
            _eFCoreTutorialContext.FDNP_Group_CC.UpdateRange(fDNP_Group_CCList);
        }
    }
}
