using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty
{
    public class FDNP_Address_CC
    {
        [Key]
        public int FDNP_Address_CC_Id { get; set; }

        public string Name { get; set; }


        #region Blogger_CC

        //Foriegn Key Property
        public int FDNP_Blogger_CCId { get; set; }

        //Reference Navigation Property(OneToOne)
        public FDNP_Blogger_CC FDNP_Blogger_CC { get; set; }

        #endregion


        #region Constructors

        public FDNP_Address_CC(string addressName)
        {
            Name = addressName;
        }

        public FDNP_Address_CC()
        { }

        #endregion

    }
}
