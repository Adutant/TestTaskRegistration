using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RegistrationTests.Models;
using SeleniumExtras.PageObjects;

namespace RegistrationTests.Pages
{
    public class RegistrationPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "signup-payed-email")]
        private IWebElement _emailField { get; set; }
        
        [FindsBy(How = How.Id, Using = "signup-payed-full_name")]
        private IWebElement _nameField { get; set; }
        
        [FindsBy(How = How.Id, Using = "signup-payed-company")]
        private IWebElement _companyField { get; set; }
        
        [FindsBy(How = How.Id, Using = "signup-payed-position")]
        private IWebElement _positionDropDownList { get; set; }
        
        [FindsBy(How = How.Id, Using = "signup-payed-phone")]
        private IWebElement _phoneField { get; set; }
        
        [FindsBy(How = How.Id, Using = "payed-signup-button")]
        private IWebElement _signUpButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[contains(text(), 'Спасибо!')]")]
        private IWebElement _successModal { get; set; }

        public void EnterRegistrationForm(RegistrationFormData registrationData)
        {
            _emailField.SendKeys(registrationData.Email);
            _nameField.SendKeys(registrationData.Name);
            _companyField.SendKeys(registrationData.Company);
            _positionDropDownList.Click();
            _positionDropDownList.FindElement(By.XPath("//*[contains(text(), 'Менеджер продукта')]")).Click();
            _phoneField.SendKeys(registrationData.Phone);
            _signUpButton.Click();
        }

        public bool IsSuccessModalShown()
        {
            Thread.Sleep(1000);
            return _successModal.Displayed;
        }
    }
}