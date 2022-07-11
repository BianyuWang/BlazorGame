using BlazorGame.Shared.Models;
using System.Net;

namespace BlazorGame.Client.Service
{
    public class DevRecordService : IDevRecordService
    {
        public List<LogInfo> ReadDevRecord()
        {
            List<LogInfo> t = new List<LogInfo>();
            string rootpath = Path.Combine(Directory.GetCurrentDirectory());
            var d = AppDomain.CurrentDomain.BaseDirectory;
           
            StreamReader r = new StreamReader($"{d}/txt/LogIndex.json");
            //string jsonString = r.ReadToEnd();
            //LogInfo m = JsonConvert.DeserializeObject<LogInfo>(jsonString);
         //   File.ReadAllText("data.txt");
            return t;
        }
    }
}
