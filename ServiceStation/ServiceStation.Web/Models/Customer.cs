using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServiceStation.Web.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [DisplayName ("Full Name")]
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        public bool IsDeleted { get; set; } = false;

        // one customer can have many vehicles 1:M relationship
        public List <Vehicle> Vehicles { get; set; }=new List<Vehicle>();
    }
}
