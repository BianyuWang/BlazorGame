using BlazorGame.Shared.Models;

namespace BlazorGame.Client.Service
{
  public  interface  IUnitService
    {
       static  IList<Unit> UnitTypeList { get; set; }
        List<Unit> MyUnitList { get; set; }
        List<Unit> ComMonster { get; set; }
        Task<List<Unit>> GeneraterMosterList();
        Task<Unit> AddUnit(UnitType unitType);
    
        Task<List<Unit>> RandomSortMonster();
        void DeleteUnit(Unit unit);

        void Attack(Unit Attacker, Unit Defender);

        IList<Unit> GetUnitType();

        List<Unit> GetMyUnit();

    }
}
