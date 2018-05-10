using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_10
{
    class BrandsPage
    {
        private readonly By ShowAllBrandsButton = By.XPath("//input[@id='model_id']");
        private readonly By Brands = By.XPath("ul[@class='brandsitem brandsitem--primary']");
        private readonly By Message = By.XPath($"//span[contains(text(),'{}')]");
        private IWebDriver webDriver;
        public List<string> listOfBrands;

        public BrandsPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public BrandsPage GetListOfBrands()
        {
            webDriver.FindElement(ShowAllBrandsButton).Click();
            ReadOnlyCollection<IWebElement> brands = webDriver.FindElements(Brands);
            listOfBrands = new List<string>();
            foreach (IWebElement element in brands)
            {
                listOfBrands.Add(element.Text);
            }
            return this;
        }
        public BrandsPage GoToBrand(string brand)
        {
            
        webDriver.FindElement("").Click();
        }
    }
}
