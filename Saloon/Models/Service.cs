using System.ComponentModel.DataAnnotations;

namespace Saloon
{
    public class Service
    {
        [Key]
        public string ServiceID { get; set; }
        public string ServiceName { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
