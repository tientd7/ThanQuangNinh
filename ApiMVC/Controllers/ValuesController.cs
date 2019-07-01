﻿using Business.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiMVC.Controllers
{
    [Authorize(Roles = RoleEnum.Admin)]
    public class ValuesController : ApiController
    {
        private readonly IAuthenBusiness _authen;
        public ValuesController(IAuthenBusiness authen)
        {
            _authen = authen;
        }
        // GET api/values
        [AllowAnonymous]
        public IEnumerable<string> Get()
        {

            return _authen.GetRolesDto();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
