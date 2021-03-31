using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty
{
    public class FDNP_Tag_CC
    {
        [Key]
        public int FDNP_Tag_CC_Id { get; set; }

        public string Name { get; set; }


        #region Post_CC

        //Collection Navigation Property(ManyToMany)
        [NotMapped]
        public List<FDNP_Post_CC> PostList { get; set; }

        //Collection Navigation Property(OneToMany)
        public IList<FDNP_PostTag_CC> FDNP_PostTag_CC { get; set; }

        #endregion


        #region Constructors

        public FDNP_Tag_CC(string tagName)
        {
            Name = tagName;
        }

        public FDNP_Tag_CC()
        { }

        #endregion
    }
}
