using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreTutorial.Models.ModelsUsingConvention.SingleCollectionNavigationProperty
{
    public class SCNP_Point_CC
    {
        [Key]
        public int SCNP_Point_CC_ID { get; set; }

        public string Name { get; set; }



        public SCNP_Point_CC(string name)
        {
            Name = name;
        }

        public SCNP_Point_CC() { }

    }
}
