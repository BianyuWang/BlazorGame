using BlazorGame.Shared.Models;

namespace BlazorGame.Client.Service
{
    public class UnitService : IUnitService
    {
        public static IList<Unit> UnitTypeList => new List<Unit>
        {
        new Unit { Id = 1,Title = UnitType.Knight,Cost =100 },
        new Unit{ Id =2,Title = UnitType.Archer,Cost = 150},
        new Unit { Id = 3,Title =UnitType.Wizard,Cost = 200}
        };
        public IList<Unit> MyUnitList { get; set; }

        public UnitService()
        {
            MyUnitList = new List<Unit>();
        }
        public Unit AddUnit(UnitType unitType)
        {
            Unit unit; 
            switch (unitType)
            {
                case UnitType.Knight: 
                    unit = new Knight();
                 
                    break;
                case UnitType.Archer:              
                    unit = new Archer();
                
                    break;
                case UnitType.Wizard:
                    unit = new Wizard();
                  
                    break;
                default:
                    unit = new Unit();
                    break;
            }
            unit.Id = MyUnitList.Count + 1;
            MyUnitList.Add(unit);
            return unit;
        }

        public void Attack(Unit Attacker, Unit Defender)
        {

            Defender.HitPoint -= Attacker.Attack - Defender.Defense;

        }

        public void DeleteUnit(Unit unit)
        {
            MyUnitList.Remove(unit);
        }

        public IList<Unit> GetUnitType()
        {
            return UnitTypeList;
        }

        public IList<Unit> GetMyUnit()
        {
           return MyUnitList;
        }
    }
}
