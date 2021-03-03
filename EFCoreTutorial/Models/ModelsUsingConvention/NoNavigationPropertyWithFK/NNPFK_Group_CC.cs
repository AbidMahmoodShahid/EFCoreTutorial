using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreTutorial.Models.ModelsUsingConvention.NoNavigationPropertyWithFK
{
    public class NNPFK_Group_CC
    {
        [Key]
        public int NNPFK_Group_CC_Id { get; set; }

        public string Name { get; set; }


        public NNPFK_Group_CC(string groupName)
        {
            Name = groupName;
        }

        public NNPFK_Group_CC(bool createMockName)
        {
            Random random = new Random();
            double groupNumber = random.NextDouble();
            Name = "NNPFK_Group_CC_" + groupNumber;
        }

        public NNPFK_Group_CC()
        { }
    }
}
