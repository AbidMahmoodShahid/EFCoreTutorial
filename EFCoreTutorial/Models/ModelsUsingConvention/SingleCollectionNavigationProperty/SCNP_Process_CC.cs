using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreTutorial.Models.ModelsUsingConvention.SingleCollectionNavigationProperty
{
    public class SCNP_Process_CC
    {
        [Key]
        public int SCNP_Process_CC_Id { get; set; }

        public string Name { get; set; }

        //Collection Navigation Property(OneToMany)
        public List<SCNP_Group_CC> GroupList { get; set; }

        public SCNP_Process_CC(string processname)
        {
            Name = processname;
            Random random = new Random();
            double groupNumber = random.NextDouble();
            GroupList = new List<SCNP_Group_CC>()
            {
                new SCNP_Group_CC("SCNP_Group_CC_" + groupNumber),
                new SCNP_Group_CC("SCNP_Group_CC_" + groupNumber * 2),
                new SCNP_Group_CC("SCNP_Group_CC_" + groupNumber * 3),
                new SCNP_Group_CC("SCNP_Group_CC_" + groupNumber * 4),
                new SCNP_Group_CC("SCNP_Group_CC_" + groupNumber * 5),
                new SCNP_Group_CC("SCNP_Group_CC_" + groupNumber * 6),
                new SCNP_Group_CC("SCNP_Group_CC_" + groupNumber * 7),
                new SCNP_Group_CC("SCNP_Group_CC_" + groupNumber * 8)
            };
        }

        public SCNP_Process_CC()
        {
            GroupList = new List<SCNP_Group_CC>();
        }
    }
}
