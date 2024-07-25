using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CoffeeTracker_DotNet6MVC.Models
{
    public class CoffeeDay
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Today;
        [Required]
        [DisplayName("Cups Drank")]
        public int CupsDrank { get; set; }
    }
}
