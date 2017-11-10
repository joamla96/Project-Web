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


        private LecturePlanRepository() {
            LecturePlan dummy1 = new LecturePlan()
            {
                ID = 1,
                Name = "dummy1"
            };

            LecturePlan dummy2 = new LecturePlan()
            {
                ID = 2,
                Name = "dummy2"
            };

            lecturePlans.Add(dummy1);
            lecturePlans.Add(dummy2);
        }

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

        public LecturePlan GetLecturePlanByID(int id)
        {
            LecturePlan result = null;

            foreach(LecturePlan item in lecturePlans)
            {
                if(id.Equals(item.ID))
                    {
                    result = item;
                }
            }

            if(result==null)
            {
                throw new IndexOutOfRangeException();
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
