using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webApp.DataEntities
{
    [Table("Article")]
    public class Article
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Author{ get; set; }
        [Required, StringLength(50)]
        public string CategoryName { get; set; }
        [Required, StringLength(50)]
        public string ArticleName { get; set; }
        [Required, StringLength(50)]

        public string Title { get; set; }
        [Required, StringLength(50)]
        public string ImageUrl{ get; set; }
        [Required,StringLength(250)]
        public string AuthorAbout { get; set; }
    }
}
