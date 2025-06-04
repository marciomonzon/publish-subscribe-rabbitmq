namespace Shared.Events
{
    public class CustomerCreatedEvent
    {
        public CustomerCreatedEvent(string fullName, string email)
        {
            FullName = fullName.Trim();
            Email = email.Trim();
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
    }
}
