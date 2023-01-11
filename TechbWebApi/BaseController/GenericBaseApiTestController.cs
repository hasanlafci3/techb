using Microsoft.AspNetCore.Mvc;

namespace TechbWebApi.BaseController
{

    public class GenericBaseApiTestController : GenericBaseApiController
    {
        public GenericBaseApiTestController()
        {
           
        }


        [HttpGet]
        public string Get(string id)
        {
            return $"Generic  {id}";
        }
    }
}
