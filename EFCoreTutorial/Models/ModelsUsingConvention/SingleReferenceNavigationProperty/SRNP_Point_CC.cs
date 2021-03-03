using System;
using System.ComponentModel.DataAnnotations;

namespace EFCoreTutorial.Models.ModelsUsingConvention.SingleReferenceNavigationProperty
{
    public class SRNP_Point_CC
    {
        [Key]
        public int SRNP_Point_CC_ID { get; set; }

        public string Name { get; set; }



        // Reference Navigation Property(OneToMany)
        public SRNP_Group_CC Group { get; set; }


        public SRNP_Point_CC(string name)
        {
            Name = name;
        }

        public SRNP_Point_CC(bool createMockName)
        {
            if (createMockName)
            {
                Random random = new Random();
                double pointNumber = random.NextDouble();
                Name = "SRNP_Point_CC_" + pointNumber;
            }
        }

        public SRNP_Point_CC() { }

    }
}
