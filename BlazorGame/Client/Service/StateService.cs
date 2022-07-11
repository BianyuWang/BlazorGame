
using BlazorGame.Shared.Models;

namespace BlazorGame.Client.Service
{
    public class StateService : IStateService
    {
        public int TotalCoin { get; set; } = 1000;
        public List<Unit> TotalUnits { get; set; } = new List<Unit>();

        public event Action OnChange;

        public void AddUnit(Unit newUnit)
        {
            TotalUnits.Add(newUnit);
            OnChange?.Invoke();
        }

        public void DeleteUnit(Unit unitToBeDel)
        {
            TotalUnits.Remove(unitToBeDel);
            OnChange?.Invoke();
        }

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