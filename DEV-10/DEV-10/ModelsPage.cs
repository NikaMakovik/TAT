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
    class ModelsPage
    {
        private IWebDriver webDriver;
        private readonly By Models = By.XPath("ul[@class='brandsitem brandsitem--primary']");
        public List<string> listOfModels;

        public ModelsPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        public ModelsPage GetListOfModels()
        {
            ReadOnlyCollection<IWebElement> models = webDriver.FindElements(Models);
            listOfModels = new List<string>();
            foreach (IWebElement element in models)
            {
                listOfModels.Add(element.Text);
            }
            return this;
        }
    }
}
