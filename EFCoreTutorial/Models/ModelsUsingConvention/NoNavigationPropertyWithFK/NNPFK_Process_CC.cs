using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreTutorial.Models.ModelsUsingConvention.NoNavigationPropertyWithFK
{
    public class NNPFK_Process_CC
    {
        [Key]
        public int NNPFK_Process_CC_Id { get; set; }

        public string Name { get; set; }


        public NNPFK_Process_CC(string processname)
        {
            Name = processname;
        }

        public NNPFK_Process_CC()
        { }
    }
}
