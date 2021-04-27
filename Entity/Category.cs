using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Category Name is required")]
        [DisplayName("Category Name")]
        
        public string CategoryName { get; set; }

        public string Description { get; set; }
    }
}
