using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEV_10
{
    class AvBy
    {
        public string carBrand;
        //private List<string> listOfBrands = new List<string>();
        public IWebDriver WebDriver { get; private set; }

        public void MainFunc()
        {

            WebDriver = new FirefoxDriver();
            WebDriver.Manage().Window.Maximize();
            SaveListWithBrands();
            CarFinder();
        }
        private void CarFinder()
        {
            BrandPage brandPage = new BrandPage(WebDriver);


            brandPage.GetListOfBrands();
            GetCarBrand();
            
            if (!CarBrandChecker(brandPage.listOfBrands))
            {
                Console.WriteLine("car brand is not valid");
            }
            else
            {

            }

        }

        private void SaveListWithBrands()
        {
            ?
        }
        private void GetCarBrand()
        {
            carBrand = Console.ReadLine();
        }
        private bool CarBrandChecker(List<string> listOfBrands)
        {

        }
    }
}
