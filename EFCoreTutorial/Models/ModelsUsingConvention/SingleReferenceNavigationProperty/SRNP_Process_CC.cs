using System.ComponentModel.DataAnnotations;

namespace EFCoreTutorial.Models.ModelsUsingConvention.SingleReferenceNavigationProperty
{
    public class SRNP_Process_CC
    {
        [Key]
        public int SRNP_Process_CC_Id { get; set; }

        public string Name { get; set; }



        public SRNP_Process_CC(string processname)
        {
            Name = processname;
        }

        public SRNP_Process_CC()
        { }
    }
}
