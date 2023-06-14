using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PhotoProg.Models
{
    public class Picture
    {
        [Key]
        public int PictureID { get; set; }
        [Required, Column(TypeName = "varchar(30)")]
        [DisplayName("File name")]
        public string? FileName { get; set; }
        [Required, StringLength(35)]
        [DisplayName("Picture name")]
        public string? PictureName { get; set; }
        public DateTime When { get; set; }
        [Required, StringLength(25)]
        [DisplayName("Location")]
        public string? Location { get; set; }
    }
}
