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
    class ModelPage
    {
        private IWebDriver webDriver;

        public ModelPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        public BrandPage GetListOfModels()
        {
            ReadOnlyCollection<IWebElement> models = webDriver.FindElements(Brands);
            listOfBrands = new List<string>();
            foreach (IWebElement element in brands)
            {
                listOfBrands.Add(element.Text);
            }
            return this;
        }
    }
}
