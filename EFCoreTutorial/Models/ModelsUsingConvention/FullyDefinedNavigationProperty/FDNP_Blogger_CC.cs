using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty
{
    public class FDNP_Blogger_CC
    {
        [Key]
        public int FDNP_Blogger_CC_Id { get; set; }

        public string Name { get; set; }


        #region Blog_CC

        //Reference Navigation Property(OneToOne)
        public FDNP_Blog_CC FDNP_Blog_CC { get; set; }

        //Foriegn Key Property
        public int FDNP_Blog_CC_Id { get; set; }

        #endregion

        #region Address_CC

        //Reference Navigation Property(OneToOne)
        public FDNP_Address_CC FDNP_Address_CC { get; set; }

        #endregion


        #region Constructors

        public FDNP_Blogger_CC(string bloggerName)
        {
            Name = bloggerName;
        }

        public FDNP_Blogger_CC()
        { }

        #endregion
    }
}
