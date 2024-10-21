using System.ComponentModel.DataAnnotations;

namespace server.Entity
{
    public class Address
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string PostCode { get; set; }
        [Required]
        public string Country { get; set; }
    }
}