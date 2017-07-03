using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssignmentAngular.Controllers;
using System.Web;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestService
    {
        /// <summary>
        /// Test method to check the valid service call
        /// </summary>
        [TestMethod]        
        public async void  TestMethod_ValidServiceCall()
        {
            WeatherController target = new WeatherController();
            CitiesObject citiesObject = await target.RetrieveCitiesInformation("Australia");
            Assert.IsTrue(citiesObject.NewDataSet != null);

        }

        /// <summary>
        /// Test method to check the valid service call with null/empty argument
        /// </summary>
        [TestMethod]
        public async void TestMethod_EmptyArgument()
        {
            WeatherController target = new WeatherController();
            CitiesObject citiesObject = await target.RetrieveCitiesInformation("");
            Assert.IsTrue(citiesObject.NewDataSet == null);

        }

        /// <summary>
        /// Test method to check the valid service call with null/empty argument
        /// </summary>
        [TestMethod]
        public async void TestMethod_NullArgument()
        {
            WeatherController target = new WeatherController();
            CitiesObject citiesObject = await target.RetrieveCitiesInformation(null);
            Assert.IsTrue(citiesObject.NewDataSet == null);

        }


    }
}
