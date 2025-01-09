using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyRazor
{
    public class CategoryModel
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Cartegory Name")]
        [MaxLength(30, ErrorMessage = "The Name cannot exceed 30 characters.")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Required]
        [Range(1, 100)]
        public int DisplayOrder { get; set; }
    }
}
