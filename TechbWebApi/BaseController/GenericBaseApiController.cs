using Microsoft.AspNetCore.Mvc;
using System;

namespace TechbWebApi.BaseController
{
    [Route("api/tech/aim/[controller]/[action]")]
    [ApiController]
    public class GenericBaseApiController : ControllerBase
    {
        [HttpGet]
        public string HeartBeat()
        {
            return DateTime.UtcNow.ToLongDateString();
        }
    }
}
