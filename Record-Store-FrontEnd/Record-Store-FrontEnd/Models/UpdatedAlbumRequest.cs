using System.ComponentModel.DataAnnotations;

namespace Record_Store_FrontEnd.Models
{
    public class UpdatedAlbumRequest
    {
        public string Title { get; set; }
      
        public string ImgUrl { get; set; }
        [Required(ErrorMessage = "Please enter the artist of the album")]
        public string Artist { get; set; }
        [Range(1900, 2100)]
        public int ReleaseYear { get; set; }
        [Required(ErrorMessage = "Please enter the genre of the album")]
        public string Genre { get; set; }
        [Range(0, 100)]
        public int Stock { get; set; }
    }
}
