using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCoreTutorial.Models.ModelsUsingConvention.SingleCollectionNavigationPropertyWithFK
{
    public class SCNPFK_Process_CC
    {
        [Key]
        public int SCNPFK_Process_CC_Id { get; set; }

        public string Name { get; set; }



        //Collection Navigation Property(OneToMany)
        public List<SCNPFK_Group_CC> GroupList { get; set; }

        public SCNPFK_Process_CC(string processname)
        {
            Name = processname;
            Random random = new Random();
            double groupNumber = random.NextDouble();
            GroupList = new List<SCNPFK_Group_CC>()
            {
                new SCNPFK_Group_CC("SCNPFK_Group_CC_" + groupNumber),
                new SCNPFK_Group_CC("SCNPFK_Group_CC_" + groupNumber * 2),
                new SCNPFK_Group_CC("SCNPFK_Group_CC_" + groupNumber * 3),
                new SCNPFK_Group_CC("SCNPFK_Group_CC_" + groupNumber * 4),
                new SCNPFK_Group_CC("SCNPFK_Group_CC_" + groupNumber * 5),
                new SCNPFK_Group_CC("SCNPFK_Group_CC_" + groupNumber * 6),
                new SCNPFK_Group_CC("SCNPFK_Group_CC_" + groupNumber * 7),
                new SCNPFK_Group_CC("SCNPFK_Group_CC_" + groupNumber * 8)
            };
        }

        public SCNPFK_Process_CC()
        {
            GroupList = new List<SCNPFK_Group_CC>();
        }
    }
}
