
using System.ComponentModel.DataAnnotations;

namespace Primal_e.Data.Models
{
    public class User
    {

        public User(string emailAddress, string name, string password)
        {
            ValidateEmailAddress(emailAddress.Trim());
            ValidateName(name);
            ValidatePassword(password);
            Name = name.Trim();
            EmailAddress = emailAddress.Trim();
            Password = password.Trim();
        }

        private void ValidatePassword(string password)
        {
            if (password.Length <= 8)
            {
                throw new ArgumentOutOfRangeException(password, "password must be greater than 8 characters");
            }

        }

        private void ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(name, "The name must not be null or empty");
            }
        }

        private void ValidateEmailAddress(string emailAddress)
        {
            if (!new EmailAddressAttribute().IsValid(emailAddress))
            {
                throw new ArgumentOutOfRangeException(emailAddress, "emailAddress is not a valid email address");
            }

        }

        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }
    }
}