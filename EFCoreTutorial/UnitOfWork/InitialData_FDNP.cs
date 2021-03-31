using EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTutorial.UnitOfWork
{
    public class InitialData_FDNP
    {
        public List<FDNP_Process_CC> FDNP_Process_CC_List { get; private set; }

        public List<FDNP_Blog_CC> FDNP_Blog_CC_List { get; private set; }

        public List<FDNP_Blogger_CC> FDNP_Blogger_CC_List { get; private set; }

        public List<FDNP_Address_CC> FDNP_Address_CC_List { get; private set; }


        public InitialData_FDNP()
        {
            FDNP_Process_CC_List = new List<FDNP_Process_CC>();
            FDNP_Blog_CC_List = new List<FDNP_Blog_CC>();
            FDNP_Blogger_CC_List = new List<FDNP_Blogger_CC>();
            FDNP_Address_CC_List = new List<FDNP_Address_CC>();

            CreateProcessSet();
            CreateBlogSet();
            CreateBloggerSet();

            AddToDatabase();
        }

        private void CreateProcessSet()
        {
            FDNP_Process_CC fDNP_Process_CC_1 = new FDNP_Process_CC("Process 1");
            FDNP_Process_CC fDNP_Process_CC_2 = new FDNP_Process_CC("Process 2");
            FDNP_Process_CC fDNP_Process_CC_3 = new FDNP_Process_CC("Process 3");

            FDNP_Process_CC_List.Add(fDNP_Process_CC_1);
            FDNP_Process_CC_List.Add(fDNP_Process_CC_2);
            FDNP_Process_CC_List.Add(fDNP_Process_CC_3);
        }

        private void CreateBlogSet()
        {
            FDNP_Blog_CC fDNP_Blog_CC_1 = new FDNP_Blog_CC("Blog 1");
            fDNP_Blog_CC_1.FDNP_Process_CCId = FDNP_Process_CC_List[0].FDNP_Process_CC_Id;
            FDNP_Blog_CC fDNP_Blog_CC_2 = new FDNP_Blog_CC("Blog 2");
            fDNP_Blog_CC_2.FDNP_Process_CCId = FDNP_Process_CC_List[1].FDNP_Process_CC_Id;
            FDNP_Blog_CC fDNP_Blog_CC_3 = new FDNP_Blog_CC("Blog 3");
            fDNP_Blog_CC_3.FDNP_Process_CCId = FDNP_Process_CC_List[2].FDNP_Process_CC_Id;

            FDNP_Blog_CC_List.Add(fDNP_Blog_CC_1);
            FDNP_Blog_CC_List.Add(fDNP_Blog_CC_2);
            FDNP_Blog_CC_List.Add(fDNP_Blog_CC_3);
        }

        private void CreateBloggerSet()
        {
            FDNP_Blogger_CC fDNP_Blogger_CC_1 = new FDNP_Blogger_CC("Blogger 1");
            FDNP_Blogger_CC fDNP_Blogger_CC_2 = new FDNP_Blogger_CC("Blogger 2");
            FDNP_Blogger_CC fDNP_Blogger_CC_3 = new FDNP_Blogger_CC("Blogger 3");

            FDNP_Blogger_CC_List.Add(fDNP_Blogger_CC_1);
            FDNP_Blogger_CC_List.Add(fDNP_Blogger_CC_2);
            FDNP_Blogger_CC_List.Add(fDNP_Blogger_CC_3);



            FDNP_Address_CC fDNP_Address_CC_1 = new FDNP_Address_CC("Address 1");
            fDNP_Address_CC_1.FDNP_Blogger_CCId = fDNP_Blogger_CC_1.FDNP_Blogger_CC_Id;
            FDNP_Address_CC fDNP_Address_CC_2 = new FDNP_Address_CC("Address 2");
            fDNP_Address_CC_2.FDNP_Blogger_CCId = fDNP_Blogger_CC_2.FDNP_Blogger_CC_Id;
            FDNP_Address_CC fDNP_Address_CC_3 = new FDNP_Address_CC("Address 3");
            fDNP_Address_CC_3.FDNP_Blogger_CCId = fDNP_Blogger_CC_3.FDNP_Blogger_CC_Id;

            FDNP_Address_CC_List.Add(fDNP_Address_CC_1);
            FDNP_Address_CC_List.Add(fDNP_Address_CC_2);
            FDNP_Address_CC_List.Add(fDNP_Address_CC_3);
        }


        private void AddToDatabase()
        {
            using(FDNP_CC_UnitOfWork uow = new FDNP_CC_UnitOfWork())
            {
                uow.FDNP_Process_CC_Repo.UpdateRange(FDNP_Process_CC_List);
                uow.FDNP_Blog_CC_Repo.UpdateRange(FDNP_Blog_CC_List);
                uow.FDNP_Blogger_CC_Repo.UpdateRange(FDNP_Blogger_CC_List);
                uow.FDNP_Address_CC_Repo.UpdateRange(FDNP_Address_CC_List);
                uow.SaveChanges();
            }
        }
    }
}
