using BlazorGame.Shared.Models;
using System.Reflection;

namespace BlazorGame.Client.Service
{
    public class UnitService : IUnitService
    {
        private HttpClient _HttpClient;
        public static IList<Unit> UnitTypeList => new List<Unit>
        {
        new Unit { Id = 1,Title = UnitType.Knight },
        new Unit{ Id =2,Title = UnitType.Archer},
        new Unit { Id = 3,Title =UnitType.Wizard}
        };
        public IList<Unit> MyUnitList { get; set; }

        public UnitService(HttpClient HttpClient)
        {
            _HttpClient = HttpClient;
            MyUnitList = new List<Unit>();
        }

        private static object CreateInstanceByClassName(string unitType)
        {
            var assembly = typeof(Unit).Assembly;         
            var type = assembly.GetTypes()
                .First(x => x.Name == unitType);
            return Activator.CreateInstance(type);
        }
        public async Task<Unit> AddUnit(UnitType unitType)
        {
            object obj = CreateInstanceByClassName(unitType.ToString());
            Unit unit = (Unit)obj;
           var nane= await  _HttpClient.GetStringAsync("api/Name");
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
