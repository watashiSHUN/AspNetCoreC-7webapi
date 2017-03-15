using System;
using System.Collections.Generic;
using System.Web.Http;

namespace netFrameworkTest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        private void ReturnStr(out string str1)
        {
            str1 = "new out syntax";
        }

        // GET api/values/5
        public string Get(int id)
        {
            ReturnStr(out string temp);
            return temp;
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
