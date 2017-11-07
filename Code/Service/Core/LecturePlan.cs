using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    class LecturePlan
    {
        public string Name { get; set; }
        private List<LecturePlanEntry> Entries = new List<LecturePlanEntry>();

        public void AddEntry(LecturePlanEntry entry)
        {
            Entries.Add(entry);
        }
    }
}
