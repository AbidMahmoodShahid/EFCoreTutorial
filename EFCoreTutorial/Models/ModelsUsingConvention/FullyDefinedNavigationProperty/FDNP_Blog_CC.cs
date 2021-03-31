using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty
{
    public class FDNP_Blog_CC
    {
        [Key]
        public int FDNP_Blog_CC_Id { get; set; }

        public string Name { get; set; }


        #region Post_CC

        //Collection Navigation Property(OneToMany)
        public List<FDNP_Post_CC> PostList { get; set; }

        #endregion

        #region Process_CC

        //Foriegn Key Property
        public int FDNP_Process_CCId { get; set; }

        //Reference Navigation Property(OneToOne)
        public FDNP_Process_CC FDNP_Process_CC { get; set; }

        #endregion


        #region Constructors

        public FDNP_Blog_CC(string processname)
        {
            Name = processname;
            Random random = new Random();
            double postNumber = random.NextDouble();
            PostList = new List<FDNP_Post_CC>()
            {
                new FDNP_Post_CC("FDNP_Post_CC" + postNumber),
                new FDNP_Post_CC("FDNP_Post_CC" + postNumber * 2),
                new FDNP_Post_CC("FDNP_Post_CC" + postNumber * 3),
                new FDNP_Post_CC("FDNP_Post_CC" + postNumber * 4),
                new FDNP_Post_CC("FDNP_Post_CC" + postNumber * 5),
                new FDNP_Post_CC("FDNP_Post_CC" + postNumber * 6),
                new FDNP_Post_CC("FDNP_Post_CC" + postNumber * 7),
                new FDNP_Post_CC("FDNP_Post_CC" + postNumber * 8)
            };
        }

        public FDNP_Blog_CC()
        {
            PostList = new List<FDNP_Post_CC>();
        }

        #endregion
    }
}
