using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }

        //Creating these two properties we are defining the relationship between AppUser and Photo tables
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }

    }
}