namespace ApiPublisher.Models
{
    public class CustomerInputModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string FullAddress { get; set; } = string.Empty;
    }
}
