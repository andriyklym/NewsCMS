using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsEngine.Models
{
    public class User
    {
        #region Constructors
        public User() { }
        #endregion

        #region Public properties

        [Key]
        public Guid ID { get; set; }
        public Guid ActivationKey { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public Group Group { get; set; }
        public Guid GroupID { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LastLogin { get; set; }

        #endregion


    }
}
