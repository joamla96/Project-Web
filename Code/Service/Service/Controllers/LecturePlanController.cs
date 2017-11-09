using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Linq;
using Core;
using System.Web.Script.Serialization;

namespace Service.Controllers
{
    public class LecturePlanController : ApiController
    {
        public string Get()
        {
            return "Please specify lectureplan";
        }

        // GET: api/LecturePlan/5
        public LecturePlan Get(int id)
        {
            return LecturePlanRepository.Instance.GetLecturePlanByID(id);
        }

        //// POST: api/LecturePlan
        //public void Post([FromBody]LecturePlan lectureplan)
        //{
        //    LecturePlanRepository.Instance.AddLecturePlan(lectureplan);
        //}



        public IEnumerable<string> GetAll()
        {
            List<string> result = new List<string>();

            List<LecturePlan> plans = LecturePlanRepository.Instance.GetAllLecturePlans().ToList<LecturePlan>();

            foreach(LecturePlan item in plans)
            {
                string json = new JavaScriptSerializer().Serialize(item);
                result.Add(json);
            }
            return result;


        }
    }
}
