using System.ComponentModel.DataAnnotations;

namespace alodge1.Models
{
    public class Category
    {
        [Key]

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int price { get; set; }
        [Required]
        public string imageurl { get; set; }

        [Required]
        public string description { get; set; }
    }
}
