namespace Pracuj.Models
{
    public class Address : IEntity<int>
    {
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
    }

}
