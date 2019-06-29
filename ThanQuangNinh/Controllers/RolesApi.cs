using Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ThanQuangNinh.Controllers
{
    public class RolesController : ApiController
    {
        private readonly IAuthenBusiness authenBusiness;
        public RolesController(IAuthenBusiness authenBusiness)
        {
            this.authenBusiness = authenBusiness;
        }
        // GET api/<controller>

        public IEnumerable<string> Get()
        {
            var Roles = authenBusiness.GetRolesDto();
            var sR = (from b in Roles
                     select b.Name).ToArray();
            return sR;
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