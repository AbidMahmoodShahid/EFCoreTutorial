using EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTutorial.Configurations
{
    public static class FDNP_CC_Configuration
    {
        public static void SetFDNP_CC_Configuration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FDNP_PostTag_CC>().HasKey(posttag => new { posttag.FDNP_Post_CCId, posttag.FDNP_Tag_CCId });
        }
    }
}
