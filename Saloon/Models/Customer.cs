using System.ComponentModel.DataAnnotations;

namespace Saloon
{
    public class Customer
    {
        [Key]
        public string NIC { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Service> Services { get; set; }

    }
}
