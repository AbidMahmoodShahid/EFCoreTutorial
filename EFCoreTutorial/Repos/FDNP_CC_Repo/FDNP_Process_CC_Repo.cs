using EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTutorial.Repos.FDNP_CC_Repo
{
    public class FDNP_Process_CC_Repo : IFDNP_Process_CC_Repo
    {
        private EFCoreTutorialContext _eFCoreTutorialContext;

        public FDNP_Process_CC_Repo(EFCoreTutorialContext eFCoreTutorialContext)
        {
            _eFCoreTutorialContext = eFCoreTutorialContext;
        }

        public async Task Attach(FDNP_Process_CC fDNP_Process_CC)
        {
            _eFCoreTutorialContext.FDNP_Process_CC.Attach(fDNP_Process_CC);
        }

        public async Task AttachRange(List<FDNP_Process_CC> fDNP_Process_CCList)
        {
            _eFCoreTutorialContext.FDNP_Process_CC.AttachRange(fDNP_Process_CCList);
        }

        public async Task Delete(FDNP_Process_CC fDNP_Process_CC)
        {
            _eFCoreTutorialContext.FDNP_Process_CC.Remove(fDNP_Process_CC);
        }

        public async Task<List<FDNP_Process_CC>> GetAll()
        {
            return _eFCoreTutorialContext.FDNP_Process_CC.Include(process => process.GroupList).ToList();
        }

        public async Task Update(FDNP_Process_CC fDNP_Process_CC)
        {
            _eFCoreTutorialContext.FDNP_Process_CC.Update(fDNP_Process_CC);
        }

        public async Task UpdateRange(List<FDNP_Process_CC> fDNP_Process_CCList)
        {
            _eFCoreTutorialContext.FDNP_Process_CC.UpdateRange(fDNP_Process_CCList);
        }
    }
}
