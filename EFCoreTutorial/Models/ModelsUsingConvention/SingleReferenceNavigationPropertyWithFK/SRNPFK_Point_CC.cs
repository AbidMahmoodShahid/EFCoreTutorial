using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreTutorial.Models.ModelsUsingConvention.SingleReferenceNavigationPropertyWithFK
{
    public class SRNPFK_Point_CC
    {
        [Key]
        public int SRNPFK_Point_CC_ID { get; set; }

        public string Name { get; set; }




        // Reference Navigation Property(OneToMany)
        public SRNPFK_Group_CC Group { get; set; }

        // Foriegn Key Property
        public int SRNPFK_Group_CC_Id { get; set; }



        public SRNPFK_Point_CC(string name)
        {
            Name = name;
        }

        public SRNPFK_Point_CC(bool createMockName)
        {
            if (createMockName)
            {
                Random random = new Random();
                double pointNumber = random.NextDouble();
                Name = "SRNPFK_Point_CC" + pointNumber;
            }
        }

        public SRNPFK_Point_CC()
        { }
    }
}
