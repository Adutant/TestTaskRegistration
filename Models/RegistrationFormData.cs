namespace RegistrationTests.Models
{
    public class RegistrationFormData
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }

        public static RegistrationFormData Create(
            string email = "test@gmail.com",
            string name = "Peter Tomas",
            string company = "Google",
            string position = "Менеджер продукта",
            string phone = "+79999999999")
        {
           return new RegistrationFormData
           {
               Email = email,
               Name = name,
               Company = company,
               Position = position,
               Phone = phone
           };
        }
    }
}