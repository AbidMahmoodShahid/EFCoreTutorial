using EFCoreTutorial.UnitOfWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UOWImplementation;

namespace EFCoreTutorialTest
{
    [TestClass]
    public class FDNP_CC
    {
        bool _databaseEmpty;

        public FDNP_CC()
        {
            _databaseEmpty = true;
            AddInitialDataToDatabase();
        }

        [TestMethod]
        public void AddInitialDataToDatabase()
        {
            if(_databaseEmpty)
            {
                FDNP_CC_Implementation fDNP_CC_Implementation = new FDNP_CC_Implementation();
                fDNP_CC_Implementation.InitialAddToDatabase();
            }
        }
    }
}
