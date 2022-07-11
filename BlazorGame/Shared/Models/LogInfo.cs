using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorGame.Shared.Models
{
    public class LogInfo
    {
        public string? DateLog { get; set; }
        public string? Summary { get; set; }
        public List<LogMsg>? Messages { get; set; }
    }

    public class Root
    {
        public List<LogInfo> logs { get; set; }
    }

    public class LogMsg
    {
        public string? messageText { get; set; }
        public string? messageImg { get; set; }
    }
}
