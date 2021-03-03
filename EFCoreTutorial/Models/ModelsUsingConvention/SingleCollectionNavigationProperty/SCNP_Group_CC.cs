using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreTutorial.Models.ModelsUsingConvention.SingleCollectionNavigationProperty
{
    public class SCNP_Group_CC
    {
        [Key]
        public int SCNP_Group_CC_Id { get; set; }

        public string Name { get; set; }



        //Collection Navigation Property(OneToMany)
        public List<SCNP_Point_CC> Points { get; set; }


        public SCNP_Group_CC(string groupName)
        {
            Name = groupName;
            Random random = new Random();
            double pointNumber = random.NextDouble();
            Points = new List<SCNP_Point_CC>()
            {
                new SCNP_Point_CC("SCNP_Point_CC_" + pointNumber),
                new SCNP_Point_CC("SCNP_Point_CC_" + pointNumber * 2),
                new SCNP_Point_CC("SCNP_Point_CC_" + pointNumber * 3),
                new SCNP_Point_CC("SCNP_Point_CC_" + pointNumber * 4),
                new SCNP_Point_CC("SCNP_Point_CC_" + pointNumber * 5),
                new SCNP_Point_CC("SCNP_Point_CC_" + pointNumber * 6),
                new SCNP_Point_CC("SCNP_Point_CC_" + pointNumber * 7),
                new SCNP_Point_CC("SCNP_Point_CC_" + pointNumber * 8)
            };
        }

        public SCNP_Group_CC()
        {
            Points = new List<SCNP_Point_CC>();
        }
    }
}
