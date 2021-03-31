using System.ComponentModel.DataAnnotations;

namespace EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty
{
    public class FDNP_Point_CC
    {
        [Key]
        public int FDNP_Point_CC_ID { get; set; }

        public string Name { get; set; }


        #region Group_CC

        // Reference Navigation Property(OneToMany)
        public FDNP_Group_CC Group { get; set; }

        // Foriegn Key Property
        public int FDNP_Group_CC_Id { get; set; }

        #endregion


        public FDNP_Point_CC(string name)
        {
            Name = name;
        }

        public FDNP_Point_CC() { }

    }
}
