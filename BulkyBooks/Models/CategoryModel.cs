using System.ComponentModel;

namespace BulkyBooks.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        [DisplayName("Cartegory Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
