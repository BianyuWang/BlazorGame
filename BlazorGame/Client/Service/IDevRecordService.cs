using BlazorGame.Shared.Models;

namespace BlazorGame.Client.Service
{
    public interface IDevRecordService
    {

        List<LogInfo> ReadDevRecord();
    }
}
