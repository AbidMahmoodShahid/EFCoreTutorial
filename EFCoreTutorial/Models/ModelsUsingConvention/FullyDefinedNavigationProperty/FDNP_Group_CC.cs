﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty
{
    public class FDNP_Group_CC
    {
        [Key]
        public int FDNP_Group_CC_Id { get; set; }

        public string Name { get; set; }



        // Reference Navigation Property(OneToMany)
        public FDNP_Process_CC Process { get; set; }

        // Foriegn Key Property
        public int FDNP_Process_CC_Id { get; set; }



        //Collection Navigation Property(OneToMany)
        public List<FDNP_Point_CC> Points { get; set; }


        public FDNP_Group_CC(string groupName)
        {
            Name = groupName;
            Random random = new Random();
            double pointNumber = random.NextDouble();
            Points = new List<FDNP_Point_CC>()
            {
                new FDNP_Point_CC("FDNP_Point_CC_" + pointNumber),
                new FDNP_Point_CC("FDNP_Point_CC_" + pointNumber * 2),
                new FDNP_Point_CC("FDNP_Point_CC_" + pointNumber * 3),
                new FDNP_Point_CC("FDNP_Point_CC_" + pointNumber * 4),
                new FDNP_Point_CC("FDNP_Point_CC_" + pointNumber * 5),
                new FDNP_Point_CC("FDNP_Point_CC_" + pointNumber * 6),
                new FDNP_Point_CC("FDNP_Point_CC_" + pointNumber * 7),
                new FDNP_Point_CC("FDNP_Point_CC_" + pointNumber * 8)
            };
        }

        public FDNP_Group_CC()
        {
            Points = new List<FDNP_Point_CC>();
        }
    }
}
