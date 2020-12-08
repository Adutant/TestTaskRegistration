using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RegistrationTests.Pages
{
    public class StartPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@action='/ru/signup']/button[@data-type='page_header']")]
        private IWebElement SignUpButton { get; set; }
        
        [FindsBy(How = How.Id, Using = "adroll_allow_all")]
        private IWebElement AcceptCookieButton { get; set; }
        
        [FindsBy(How = How.Id, Using = "adroll_consent_banner")]
        private IWebElement CookieBanner { get; set; }

        public StartPage Invoke()
        {
            Driver.Url = "https://appfollow.io/ru";
            return this;
        }

        public StartPage AcceptCookie()
        {
            if (CookieBanner.Displayed)
            {
                AcceptCookieButton.Click();
            }

            return this;
        }
        
        public void SignUp()
        {
            SignUpButton.Click();
        }
    }
}