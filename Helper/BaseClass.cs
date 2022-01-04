using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingInTest.Helper
{

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Support.UI;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    namespace Selenium2017Test.Helper
    {

        public class BaseClass
        {
            public static IWebDriver driver { get; set; }
            private static SelectElement select;


            static BaseClass()
            {
                driver = null;
                select = null;
            }


            public static void SelectByIndex(IWebElement element, int index)
            {
                select = new SelectElement(element);
                select.SelectByIndex(index);
            }

            public static void SelectByValue(IWebElement element, String value)
            {
                select = new SelectElement(element);
                select.SelectByValue(value);
            }

            public static void SelectByText(IWebElement element, String text)
            {
                select = new SelectElement(element);
                select.SelectByText(text);
            }


            public static void LaunchBrowser(String browser)
            {
                switch (browser)
                {
                    case "Chrome":
                        driver = initialiseChrome();
                        break;
                    case "Firefox":
                        driver = initialiseFirefox();
                        break;
                    default:
                        Console.WriteLine(browser + " is not recognised. So Firefox is launched instead");
                        driver = initialiseFirefox();
                        break;
                }

                driver.Manage().Window.Maximize();
            }

            private static IWebDriver initialiseChrome()
            {
                driver = new ChromeDriver();

                return driver;
            }

            private static IWebDriver initialiseFirefox()
            {
                driver = new FirefoxDriver();

                return driver;
            }

            public static void CloseBrowser()
            {
                driver.Manage().Cookies.DeleteAllCookies();
                driver.Close();
                driver.Quit();
            }

            public static void LaunchUrl(String Url)
            {
                driver.Navigate().GoToUrl(Url);
            }

            public static IWebElement GetElementById(String id)
            {
                By locator = By.Id(id);
                return GetElementById(id);
            }

            public static IWebElement GetElementByClassName(String className)
            {
                By locator = By.ClassName(className);
                return GetElementByClassName(className);
            }

            public static IWebElement GetElementByName(String name)
            {
                By locator = By.Name(name);
                return GetElementByName(name);
            }

            public static IWebElement GetElementByCssSelector(String cssSelector)
            {
                By locator = By.CssSelector(cssSelector);
                return GetElementByCssSelector(cssSelector);
            }

            public static IWebElement GetElementByXpath(String xpath)
            {
                By locator = By.XPath(xpath);
                return GetElementByXpath(xpath);
            }

            public static IWebElement GetElementByLinkText(String linktext)
            {
                By locator = By.LinkText(linktext);
                return GetElementByLinkText(linktext);
            }


            public static LoginPage GivenINavigateLoadLoginPage()
            {
                LaunchUrl("");

                return new LoginPage();

            }

        }


        driver.findElement(By.xpath("//header/nav[@id='atds-navigation']/div[1]/div[1]/a[1]/*[1]"))

}
