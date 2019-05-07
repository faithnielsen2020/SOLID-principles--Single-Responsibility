using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLogProject.Model
{
    public class WorkLogReport:IEntryReport<WorkLogModel>
    {
        private readonly List<WorkLogModel> workEntries;

        public WorkLogReport()
        {
            workEntries = new List<WorkLogModel>();
            
        }



        public void addEntry(WorkLogModel entry)
        {
            workEntries.Add(entry);
        }

        public void deleteEntry(string code)
        {
            var itemFound = workEntries.Find(x => x.TaskCode == code);
            if (itemFound != null) workEntries.Remove(itemFound);
        }


        //Problem: If we have this method in this class, then we will violate Single Reponsibility principle.
        //Solution: Move this funtionality to a new class
        public void SaveWorkReportToFile(string directoryPath, string fileName)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            File.WriteAllText(Path.Combine(directoryPath, fileName), workEntries.ToString());
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, workEntries.Select(x => $"Task Code: {x.TaskCode}, Name of Task: {x.TaskName}, Hours Worked: {x.HoursSpent}"));
        }

    }
}
