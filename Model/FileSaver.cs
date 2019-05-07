using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace WorkLogProject.Model
{
    //This class is solely responsible for saving data to different mediums


    
    public class DataSaver
    {
        //Save data to file
        public void SaveWorkReportToFile(string directoryPath, string fileName, WorkLogReport workLogreport)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            File.WriteAllText(Path.Combine(directoryPath, fileName), workLogreport.ToString());
        }

        //Save Data to a Database

        //Save data to Cloud

        //...
    }
}
