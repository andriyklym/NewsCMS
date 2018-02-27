using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsEngine.Models
{
    public class News
    {

        #region Constructors
        public News() { }
        #endregion

        #region Public properties

        [Key]
        public Guid ID { get; set; }
        public string Title { get; set; }
        public User Author { get; set; }
        public Guid AuthorID { get; set; }
        public string ShortStory { get; set; }
        public string FullStory { get; set; }
        public Category Category { get; set; }
        public Guid CategoryID { get; set; }
        public string ImgTitle { get; set; }

        #endregion
    }
}
