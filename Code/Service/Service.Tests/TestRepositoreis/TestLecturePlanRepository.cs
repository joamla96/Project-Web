using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Tests.TestRepositoreis
{
    class TestLecturePlanRepository : ILecturePlanRepository
    {
        private List<LecturePlan> lecturePlans = new List<LecturePlan>();

        public int AddLecturePlan(LecturePlan lectureplan)
        {
            lecturePlans.Add(lectureplan);
            return lectureplan.ID;
        }

        public void RemoveLecturePlan(LecturePlan lectureplan)
        {
            lecturePlans.Remove(lectureplan);
        }

        public LecturePlan GetLecturePlan(LecturePlan lectureplan)
        {
            LecturePlan result = null;

            foreach (LecturePlan item in lecturePlans)
            {
                if (lectureplan.Equals(item))
                {
                    result = lectureplan;
                }
            }
            if (result == null)
            {
                throw new NullReferenceException();
            }
            return result;
        }

        public IEnumerable<LecturePlan> GetAllLecturePlans()
        {
            return lecturePlans;
        }

        public LecturePlan GetLecturePlanByID(int id)
        {
            LecturePlan result = null;

            foreach (LecturePlan item in lecturePlans)
            {
                if (id.Equals(item.ID))
                {
                    result = item;
                }
            }

            if (result == null)
            {
                throw new NullReferenceException();
            }

            return result;
        }

        public void RemoveLecturePlanByID(int id)
        {

            LecturePlan lecturePlan = GetLecturePlanByID(id);

            RemoveLecturePlan(lecturePlan);

        }
    }
}
