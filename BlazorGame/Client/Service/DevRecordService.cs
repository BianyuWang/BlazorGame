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
            var directory = AppDomain.CurrentDomain.BaseDirectory;
           
            StreamReader r = new StreamReader($"{directory}/txt/LogIndex.json");
        
            return t;
        }
    }
}
