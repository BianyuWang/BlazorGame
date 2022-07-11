
namespace BlazorGame.Client.Service
{
    public class StateService : IStateService
    {
        public int TotalCoin { get; set; } = 1000;

        public event Action OnChange;

        public void RefoundCoin(int refound)
        {
            TotalCoin += refound;
            OnChange?.Invoke();
        }

        public void UseCoin(int cost)
        {
            TotalCoin -= cost;
            OnChange?.Invoke();
        }
    }
}