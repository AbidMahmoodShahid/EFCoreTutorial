using EFCoreTutorial.InitialMockData;
using UnitOfWorkProject;

namespace UOWImplementation
{
    public class FDNP_CC_Implementation
    {
        public FDNP_CC_Implementation()
        {

        }

        public void InitialAddToDatabase()
        {
            using(FDNP_CC_UnitOfWork uow = new FDNP_CC_UnitOfWork())
            {
                FDNP_CC_InitialMockData initialMockData = new FDNP_CC_InitialMockData();
                uow.FDNP_Process_CC_Repo.UpdateRange(initialMockData.FDNP_Process_CC_List);
                uow.FDNP_Blog_CC_Repo.UpdateRange(initialMockData.FDNP_Blog_CC_List);
                uow.FDNP_Blogger_CC_Repo.UpdateRange(initialMockData.FDNP_Blogger_CC_List);
                uow.FDNP_Address_CC_Repo.UpdateRange(initialMockData.FDNP_Address_CC_List);
                uow.SaveChanges();
            }
        }
    }
}
