using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface ILecturePlanRepository
    {
        int AddLecturePlan(LecturePlan plan);
        void RemoveLecturePlan(LecturePlan plan);
        void RemoveLecturePlanByID(int id);
        LecturePlan GetLecturePlan(LecturePlan plan);
        LecturePlan GetLecturePlanByID(int id);
        IEnumerable<LecturePlan> GetAllLecturePlans();
    }
}
