using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Service.Controllers
{
	public class DefaultController : ApiController
	{
		// GET api/<controller>
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		[Route("Get/{id}")]
		[HttpGet]
		// GET api/<controller>/5
		public string Get(int id)
		{
			return "" + id;
		}

		// POST api/<controller>
		public string Post([FromBody]string value)
		{
			return value;
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