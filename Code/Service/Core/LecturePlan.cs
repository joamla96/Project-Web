using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class LecturePlan
    {
        public string Name { get; set; }
        private List<LecturePlanEntry> Entries = new List<LecturePlanEntry>();
        public int ID { get; set; }

        public void AddEntry(LecturePlanEntry entry)
        {
            Entries.Add(entry);
        }

        public void RemoveEntry(LecturePlanEntry entry)
        {
            Entries.Remove(entry);
        }

        public LecturePlanEntry GetEntry(LecturePlanEntry entry)
        {
            LecturePlanEntry result=null;

            foreach(LecturePlanEntry item in Entries)
            {
                if(entry.Equals(item))
                {
                    result = item;
                }
            }
            return result;
        }
    }
}
