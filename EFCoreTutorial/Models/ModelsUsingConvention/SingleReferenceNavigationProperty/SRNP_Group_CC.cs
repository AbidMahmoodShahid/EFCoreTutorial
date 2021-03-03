using System;
using System.ComponentModel.DataAnnotations;

namespace EFCoreTutorial.Models.ModelsUsingConvention.SingleReferenceNavigationProperty
{
    public class SRNP_Group_CC
    {
        [Key]
        public int SRNP_Group_CC_Id { get; set; }

        public string Name { get; set; }



        // Reference Navigation Property(OneToMany)
        public SRNP_Process_CC Process { get; set; }


        public SRNP_Group_CC(string groupName)
        {
            Name = groupName;
        }

        public SRNP_Group_CC(bool createMockName)
        {
            if (createMockName)
            {
                Random random = new Random();
                double groupNumber = random.NextDouble();
                Name = "SRNP_Group_CC_" + groupNumber;
            }
        }


        public SRNP_Group_CC()
        { }
    }
}
