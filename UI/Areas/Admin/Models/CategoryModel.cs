using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UI.Areas.Admin.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Category Name is required")]
        [DisplayName("Category Name")]

        public string CategoryName { get; set; }

        public string Description { get; set; }
    }
}
