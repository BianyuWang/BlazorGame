using BlazorGame.Shared.Models;

namespace BlazorGame.Client.Service
{
    public interface IStateService
    {
       int TotalCoin { get; set; }

        bool DisableBtnClick { get; set; }
        string CoinCss { get; set; }

        

        List<Unit> TotalUnits { get; set; }
       
        event Action OnChange; 

      void  UseCoin(int cost);

      void  RefoundCoin(int refound);

        void AddUnit(Unit newUnit);
        void DeleteUnit(Unit unitToBeDel);
    }
}
