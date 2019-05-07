using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkLogProject.Model;

namespace WorkLogProject
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkLogReport wlrList = new WorkLogReport();
            
            wlrList.addEntry(new WorkLogModel { TaskCode = "s3456", TaskName = "Tasktype1", HoursSpent = 5 });
            wlrList.addEntry(new WorkLogModel { TaskCode = "s456t", TaskName = "Tasktype2", HoursSpent = 4 });
            wlrList.addEntry(new WorkLogModel { TaskCode = "f905y", TaskName = "Tasktype3", HoursSpent = 6 });
            wlrList.addEntry(new WorkLogModel { TaskCode = "b4567", TaskName = "Tasktype4", HoursSpent = 3 });

            Console.WriteLine(wlrList.ToString());

            string directoryPathValue = @"C:\Users\FaithNielsen\Desktop\delete_Indx\TestRepo\";
            string fileNameValue = "example1.txt";


            var fileSaverObj = new DataSaver();
            fileSaverObj.SaveWorkReportToFile(directoryPathValue,fileNameValue, wlrList);

            Console.ReadLine();

        }




    }
}
