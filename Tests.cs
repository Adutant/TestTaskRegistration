using NUnit.Framework;
using RegistrationTests.Models;
using RegistrationTests.Pages;

namespace RegistrationTests
{
    [TestFixture]
    public class Tests
    {
        private StartPage _startPage = new StartPage();
        private RegistrationPage _registrationPage = new RegistrationPage();
        
        [Test]
        public void RegistrationTest()
        {
            var registrationData = RegistrationFormData.Create();
            _startPage
                .Invoke()
                .AcceptCookie()
                .SignUp();
            _registrationPage.EnterRegistrationForm(registrationData);
            Assert.IsTrue(_registrationPage.IsSuccessModalShown(), "Success modal isn't shown");
        }
    }
}