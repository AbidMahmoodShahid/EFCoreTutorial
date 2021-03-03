using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreTutorial.Models.ModelsUsingConvention.SingleReferenceNavigationPropertyWithFK
{
    public class SRNPFK_Group_CC
    {
        [Key]
        public int SRNPFK_Group_CC_Id { get; set; }

        public string Name { get; set; }



        // Reference Navigation Property(OneToMany)
        public SRNPFK_Process_CC Process { get; set; }

        // Foriegn Key Property
        public int SRNPFK_Process_CC_Id { get; set; }



        public SRNPFK_Group_CC(string groupName)
        {
            Name = groupName;
        }

        public SRNPFK_Group_CC(bool createMockName)
        {
            if (createMockName)
            {
                Random random = new Random();
                double groupNumber = random.NextDouble();
                Name = "SRNPFK_Group_CC_" + groupNumber;
            }
        }


        public SRNPFK_Group_CC()
        { }
    }
}
