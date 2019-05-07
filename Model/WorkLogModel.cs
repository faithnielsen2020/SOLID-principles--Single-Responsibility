using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLogProject.Model
{
    public class WorkLogModel
    {
        private string taskCode;
        private string taskName;
        private int hoursSpent;

        public string TaskCode { get => taskCode; set => taskCode = value; }
        public string TaskName { get => taskName; set => taskName = value; }
        public int HoursSpent { get => hoursSpent; set => hoursSpent = value; }


        //public override string ToString()
        //{
        //    //return String.Concat(taskCode,taskName,hoursSpent);*/
        //    //return String.Format(taskCode, taskName, hoursSpent);
        //    //return $"TaskCode:{taskCode}, TaskName:{taskName},HoursSpent:{hoursSpent}";
        //    //return taskCode + " " + taskName + " " + hoursSpent.ToString();
        //    //return "taskCode+taskName+hoursSpent".ToString();
        //    //return "Result: " + TaskCode + "" + TaskName + "" + HoursSpent;


        //}


    }
}
