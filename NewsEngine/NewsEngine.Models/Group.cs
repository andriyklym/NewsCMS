using System;
using System.ComponentModel.DataAnnotations;

namespace NewsEngine.Models
{
    public class Group
    {
        #region Constructors
        public Group() { }
        #endregion

        #region Public properties

        [Key]
        public Guid GroupID { get; set; }
        public string Name { get; set; }
        public bool AllowAdmin { get; set; }
        public string EditNews { get; set; }
        public bool AddNews { get; set; }
        public bool EditUsers { get; set; }

        #endregion
    }
}
