using BlazorGame.Shared.Models;

namespace BlazorGame.Client.Service
{
    public interface IStateService
    {
       int TotalCoin { get; set; }

        bool DisableBtnClick { get; set; }
        string CoinCss { get; set; }
        bool IsMonsterGenerated { get; set; }
        bool IsBattleBegin { get; set; }

        List<Unit> TotalUnits { get; set; }
        List<Unit> TotalMonsters { get; set; }
        event Action OnChange; 

      void  UseCoin(int cost);

      void  RefoundCoin(int refound);

        void AddUnit(Unit newUnit);
        void DeleteUnit(Unit unitToBeDel);
    }
}
