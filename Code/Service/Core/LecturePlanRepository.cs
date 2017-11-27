using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Core
{
    public class LecturePlanRepository : ILecturePlanRepository
    {
        private int NextIDCounter = 0;
        private static ILecturePlanRepository instance;
        public static ILecturePlanRepository Instance {
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

        public int AddLecturePlan(LecturePlan lectureplan)
        {
            lectureplan.ID = this.NextID();
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

            foreach(LecturePlan item in lecturePlans)
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

            foreach(LecturePlan item in lecturePlans)
            {
                if(id.Equals(item.ID))
                    {
                    result = item;
                }
            }

            if(result==null)
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

        private int NextID()
        {
            return ++NextIDCounter;
        }

        public int NextIDTest()
        {
            return this.NextID();
        }
    }
}
