using System.ComponentModel.DataAnnotations;

namespace Core.Entities.identity
{
    public class Address
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        [Required] //this prevents perticular field from being nullable in database
        public string AppUserId {get; set;}
        public AppUser AppUser { get; set; }
    }
}