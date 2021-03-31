using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty
{
    public class FDNP_Process_CC
    {
        [Key]
        public int FDNP_Process_CC_Id { get; set; }

        public string Name { get; set; }


        #region Group_CC

        //Collection Navigation Property(OneToMany)
        public List<FDNP_Group_CC> GroupList { get; set; }

        #endregion

        #region Blog_CC

        //Reference Navigation Property(OneToOne)
        public FDNP_Blog_CC FDNP_Blog_CC { get; set; }

        #endregion


        public FDNP_Process_CC(string processname)
        {
            Name = processname;
            Random random = new Random();
            double groupNumber = random.NextDouble();
            GroupList = new List<FDNP_Group_CC>()
            {
                new FDNP_Group_CC("FDNP_Group_CC_" + groupNumber),
                new FDNP_Group_CC("FDNP_Group_CC_" + groupNumber * 2),
                new FDNP_Group_CC("FDNP_Group_CC_" + groupNumber * 3),
                new FDNP_Group_CC("FDNP_Group_CC_" + groupNumber * 4),
                new FDNP_Group_CC("FDNP_Group_CC_" + groupNumber * 5),
                new FDNP_Group_CC("FDNP_Group_CC_" + groupNumber * 6),
                new FDNP_Group_CC("FDNP_Group_CC_" + groupNumber * 7),
                new FDNP_Group_CC("FDNP_Group_CC_" + groupNumber * 8)
            };
        }

        public FDNP_Process_CC()
        {
            GroupList = new List<FDNP_Group_CC>();
        }
    }
}
