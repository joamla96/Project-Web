using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    class LecturePlanRepository
    {
        private static LecturePlanRepository instance;
        public static LecturePlanRepository Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new LecturePlanRepository();
                }
                return instance;
            }
        }

        private LecturePlanRepository() { }

        private List<LecturePlan> lecturePlans = new List<LecturePlan>();

        public void AddLecturePlan(LecturePlan lectureplan)
        {
            lecturePlans.Add(lectureplan);
        }
    }
}
