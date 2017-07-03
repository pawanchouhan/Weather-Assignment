using AssignmentAngular.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Xml.Linq;

namespace AssignmentAngular.Controllers
{
    [RoutePrefix("weather")]
    public class WeatherController : ApiController
    {
        /// <summary>
        /// API method for retrieving the cities corresponding to a country
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{country}")]
        public async Task<CitiesObject> RetrieveCitiesInformation(string country)
        {
            CitiesObject citiesObject = new CitiesObject();
            using (WeatherService.GlobalWeatherSoapClient client = new WeatherService.GlobalWeatherSoapClient())
            {
                string response = await client.GetCitiesByCountryAsync(country);
                XDocument doc = XDocument.Parse(response);
                var json = JsonConvert.SerializeXNode(doc);
                citiesObject = JsonConvert.DeserializeObject<CitiesObject>(json);
            }

            return citiesObject;
        }        
    }
}
