using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCoreTutorial.Models.ModelsUsingConvention.SingleCollectionNavigationPropertyWithFK
{
    public class SCNPFK_Group_CC
    {
        [Key]
        public int SCNPFK_Group_CC_Id { get; set; }

        public string Name { get; set; }



        // Foriegn Key Property
        public int SCNPFK_Process_CC_Id { get; set; }



        //Collection Navigation Property(OneToMany)
        public List<SCNPFK_Point_CC> Points { get; set; }


        public SCNPFK_Group_CC(string groupName)
        {
            Name = groupName;
            Random random = new Random();
            double pointNumber = random.NextDouble();
            Points = new List<SCNPFK_Point_CC>()
            {
                new SCNPFK_Point_CC("SCNPFK_Point_CC_" + pointNumber),
                new SCNPFK_Point_CC("SCNPFK_Point_CC_" + pointNumber * 2),
                new SCNPFK_Point_CC("SCNPFK_Point_CC_" + pointNumber * 3),
                new SCNPFK_Point_CC("SCNPFK_Point_CC_" + pointNumber * 4),
                new SCNPFK_Point_CC("SCNPFK_Point_CC_" + pointNumber * 5),
                new SCNPFK_Point_CC("SCNPFK_Point_CC_" + pointNumber * 6),
                new SCNPFK_Point_CC("SCNPFK_Point_CC_" + pointNumber * 7),
                new SCNPFK_Point_CC("SCNPFK_Point_CC_" + pointNumber * 8)
            };
        }

        public SCNPFK_Group_CC()
        {
            Points = new List<SCNPFK_Point_CC>();
        }
    }
}
