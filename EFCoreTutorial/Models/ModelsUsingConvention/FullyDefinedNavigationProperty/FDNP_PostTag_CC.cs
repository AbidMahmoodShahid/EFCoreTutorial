using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty
{
    public class FDNP_PostTag_CC
    {
        public int FDNP_Post_CCId { get; set; }
        public FDNP_Post_CC FDNP_Post_CC { get; set; }

        public int FDNP_Tag_CCId { get; set; }
        public FDNP_Tag_CC FDNP_Tag_CC { get; set; }
    }
}
