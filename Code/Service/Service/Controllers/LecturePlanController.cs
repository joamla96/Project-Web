using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Core;
using System.Web.Script.Serialization;
using System;

namespace Service.Controllers
{
    public class LecturePlanController : ApiController
    {
        private ILecturePlanRepository RepoLecturePlans;

        public LecturePlanController(ILecturePlanRepository RepoLecturePlan)
        {
            this.RepoLecturePlans = RepoLecturePlan;
        }

        public LecturePlanController()
        {
            this.RepoLecturePlans = LecturePlanRepository.Instance;
        }

        public IEnumerable<LecturePlan> Get()
        {
            return RepoLecturePlans.GetAllLecturePlans();
        }

        // GET: api/LecturePlan/5
        public LecturePlan Get(int id)
        {
            return RepoLecturePlans.GetLecturePlanByID(id);
        }

        public void Post(LecturePlan item)
        {
            throw new NotImplementedException();
        }

        //[HttpPost]
        //// POST: api/LecturePlan
        //public void Post([FromBody]LecturePlan lectureplan)
        //{
        //    LecturePlanRepository.Instance.AddLecturePlan(lectureplan);
        //}

    }
}
