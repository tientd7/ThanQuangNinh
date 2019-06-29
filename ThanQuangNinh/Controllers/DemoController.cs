using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;

namespace ThanQuangNinh.Controllers
{
    public class DemoController : ApiController
    {
        // GET api/<controller>
        public JsonResult<string[]> Get()
        {
            return Json( new string[] { "value1", "value2" });
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}