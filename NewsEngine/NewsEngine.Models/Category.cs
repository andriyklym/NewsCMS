using System;
using System.ComponentModel.DataAnnotations;

namespace NewsEngine.Models
{
    public class Category
    {

        #region Constructors
        public Category() { }
        #endregion

        #region Public properties

        [Key]
        public Guid CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AltName { get; set; }

#endregion
    }
}
