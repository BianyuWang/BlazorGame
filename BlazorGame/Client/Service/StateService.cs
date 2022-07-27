
using BlazorGame.Shared.Models;

namespace BlazorGame.Client.Service
{
    public class StateService : IStateService
    {
        public int TotalCoin { get; set; } = 1000;

        public bool IsMonsterGenerated { get; set; } = false;

        public bool DisableLevel { get; set; } = true;
       
        public List<Unit> TotalUnits { get; set; } = new List<Unit>();
        public string CoinCss { get; set; } = "sufficient";
        public bool DisableBtnClick { get; set; } = false;
        public bool IsBattleBegin { get; set; } = false;
        public List<Unit> TotalMonsters { get; set; } = new List<Unit>();

        public GameLevel gameLevel { get; set; } = GameLevel.Easy;

        public event Action OnChange;

        public  List<string> LevelExplanation { get; set; } = new List<string>
    {
    "You have complete information about the enemy and can also choose your order of battle",
    "You only know the types of enemies, and you have three chances to choose the hero to fight",
"You know nothing about the enemy, but you can choose your own order of battle",
"You only have three chances to choose the hero to fight, the rest...leave it to fate"
    };
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
            CoinCss = "sufficient";
            DisableBtnClick = false;
            if (TotalCoin < 100)
            {
                CoinCss = "insufficient";
                DisableBtnClick = true;
            }
           
            OnChange?.Invoke();
        }

        public void UseCoin(int cost)
        {
            TotalCoin -= cost;
            CoinCss = "sufficient";
            DisableBtnClick = false;
            if (TotalCoin < 100)
            {
                CoinCss = "insufficient";
                DisableBtnClick = true;
            }
        
            OnChange?.Invoke();
        }
    }
}