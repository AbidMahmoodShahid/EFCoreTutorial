using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty
{
    public class FDNP_Post_CC
    {
        [Key]
        public int FDNP_Post_CC_Id { get; set; }

        public string Name { get; set; }


        #region Blog_CC

        // Reference Navigation Property(OneToMany)
        public FDNP_Blog_CC FDNP_Blog_CC { get; set; }

        // Foriegn Key Property
        public int FDNP_Blog_CC_Id { get; set; }

        #endregion

        #region Tag_CC

        //Collection Navigation Property(ManyToMany)
        [NotMapped]
        public List<FDNP_Tag_CC> TagList { get; set; }

        //Collection Navigation Property(OneToMany)
        public IList<FDNP_PostTag_CC> FDNP_PostTag_CC { get; set; }

        #endregion

        #region Constructors

        public FDNP_Post_CC(string postName)
        {
            Name = postName;
            Random random = new Random();
            double tagNumber = random.NextDouble();
            FDNP_Tag_CC fDNP_Tag_CC_1 = new FDNP_Tag_CC("FDNP_Tag_CC" + tagNumber);
            FDNP_Tag_CC fDNP_Tag_CC_2 = new FDNP_Tag_CC("FDNP_Tag_CC" + tagNumber * 2);
            FDNP_Tag_CC fDNP_Tag_CC_3 = new FDNP_Tag_CC("FDNP_Tag_CC" + tagNumber * 3);
            FDNP_Tag_CC fDNP_Tag_CC_4 = new FDNP_Tag_CC("FDNP_Tag_CC" + tagNumber * 4);
            FDNP_Tag_CC fDNP_Tag_CC_5 = new FDNP_Tag_CC("FDNP_Tag_CC" + tagNumber * 5);

            TagList = new List<FDNP_Tag_CC>()
            {
                fDNP_Tag_CC_1,
                fDNP_Tag_CC_2,
                fDNP_Tag_CC_3,
                fDNP_Tag_CC_4,
                fDNP_Tag_CC_5,
                fDNP_Tag_CC_1,
                fDNP_Tag_CC_2,
                fDNP_Tag_CC_3,
                fDNP_Tag_CC_4,
                fDNP_Tag_CC_5
            };
        }

        public FDNP_Post_CC()
        {
            TagList = new List<FDNP_Tag_CC>();
        }

        #endregion
    }
}
