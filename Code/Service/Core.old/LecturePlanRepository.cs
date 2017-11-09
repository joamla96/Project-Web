using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class LecturePlanRepository
    {
        private static LecturePlanRepository instance;
        public static LecturePlanRepository Instance {
            get {
                if (instance == null) { instance = new LecturePlanRepository(); }
                return instance;
            }
        }

        private LecturePlanRepository() { }

        private List<LecturePlan> lecturePlans = new List<LecturePlan>();

        public void AddLecturePlan(LecturePlan lectureplan)
        {
            lecturePlans.Add(lectureplan);
        }

        public void RemoveLecturePlan(LecturePlan lectureplan)
        {
            lecturePlans.Remove(lectureplan);
        }

        public LecturePlan GetLecturePlan(LecturePlan lectureplan)
        {
            LecturePlan result = null;

            foreach(LecturePlan item in lecturePlans)
            {
                if (lectureplan.Equals(item))
                {
                    result = lectureplan;
                }
            }
            return result;
        }

        public IEnumerable<LecturePlan> GetAllLecturePlans()
        {
            return lecturePlans;
        }
    }
}
