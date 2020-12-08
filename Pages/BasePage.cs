using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace RegistrationTests.Pages
{
    public abstract class BasePage
    {
        public static IWebDriver Driver = new ChromeDriver();

        protected BasePage()
        {
            PageFactory.InitElements(Driver, this);
            Driver.Manage().Window.Maximize();
        }
        
        public static void CloseDriver()
        {
            if (Driver != null)
            {
                Driver.Dispose();
                Driver = null;
            }
        }
        
        static readonly Finalizer finalizer = new Finalizer();
        sealed class Finalizer
        {
            ~Finalizer()
            {
                CloseDriver();
            }
        }
    }
}