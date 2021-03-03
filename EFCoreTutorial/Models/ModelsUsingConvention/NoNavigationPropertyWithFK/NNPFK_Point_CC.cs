using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreTutorial.Models.ModelsUsingConvention.NoNavigationPropertyWithFK
{
    public class NNPFK_Point_CC
    {
        [Key]
        public int NNPFK_Point_CC_Id { get; set; }

        public string Name { get; set; }


        public NNPFK_Point_CC(string pointName)
        {
            Name = pointName;
        }

        public NNPFK_Point_CC(bool createMockName)
        {
            Random random = new Random();
            double pointNumber = random.NextDouble();
            Name = "NNPFK_Point_CC_" + pointNumber;
        }

        public NNPFK_Point_CC()
        { }
    }
}
