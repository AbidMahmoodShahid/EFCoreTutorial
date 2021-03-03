using System.ComponentModel.DataAnnotations;

namespace EFCoreTutorial.Models.ModelsUsingConvention.SingleCollectionNavigationPropertyWithFK
{
    public class SCNPFK_Point_CC
    {
        [Key]
        public int SCNPFK_Point_CC_ID { get; set; }

        public string Name { get; set; }



        // Foriegn Key Property
        public int SCNPFK_Group_CC_Id { get; set; }



        public SCNPFK_Point_CC(string name)
        {
            Name = name;
        }

        public SCNPFK_Point_CC() { }

    }
}
