using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreTutorial.Models.ModelsUsingConvention.SingleReferenceNavigationPropertyWithFK
{
    public class SRNPFK_Process_CC
    {
        [Key]
        public int SRNPFK_Process_CC_Id { get; set; }

        public string Name { get; set; }


        public SRNPFK_Process_CC(string processname)
        {
            Name = processname;
        }

        public SRNPFK_Process_CC()
        { }
    }
}
