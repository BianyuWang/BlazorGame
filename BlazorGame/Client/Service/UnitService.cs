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

        public List<Unit> MyUnitList { get; set; }
        public List<Unit> ComMonster { get; set; }
       
        public async Task<List<Unit>> GeneraterMosterList()
        {


            await GeneraterRdMosterList(1000);
            return ComMonster;
        }

        private async Task GeneraterRdMosterList(int totalCatCoin)
        {
            Random rd = new Random();
            Array values = Enum.GetValues(typeof(UnitType));
            Unit newMonstor = new Unit();
            UnitType randomUnitType = UnitType.Archer;

            if (totalCatCoin >= (int)UnitType.Wizard)
            {
                randomUnitType = (UnitType)values.GetValue(rd.Next(values.Length));
            }
            else if ((int)UnitType.Wizard > totalCatCoin && totalCatCoin >= (int)UnitType.Archer)
            {
                randomUnitType = (UnitType)values.GetValue(rd.Next(values.Length - 1));
            }
            else if ((int)UnitType.Archer > totalCatCoin && totalCatCoin >= (int)UnitType.Knight)
            {
                randomUnitType = UnitType.Knight;

            }
            else {
                return;
            }
            newMonstor = await CreateUnit(randomUnitType);
            newMonstor.Id = ComMonster.Count() + 1;
            ComMonster.Add(newMonstor);
            totalCatCoin -= (int)randomUnitType;
            await  GeneraterRdMosterList(totalCatCoin);
        }


        public UnitService(HttpClient HttpClient)
        {
            _HttpClient = HttpClient;
            MyUnitList = new List<Unit>();
            ComMonster = new List<Unit>();
        }

        private static object CreateInstanceByClassName(string unitType)
        {
            var assembly = typeof(Unit).Assembly;         
            var type = assembly.GetTypes()
                .First(x => x.Name == unitType);
            return Activator.CreateInstance(type);
        }

        private async Task<Unit> CreateUnit(UnitType unitType)
        {
            object obj = CreateInstanceByClassName(unitType.ToString());
            Unit unit = (Unit)obj;
            unit.Name = await _HttpClient.GetStringAsync("api/Name");
            return unit;
        }
        public async Task<Unit> AddUnit(UnitType unitType)
        {
            Unit unit = await CreateUnit(unitType);          
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

        public List<Unit> GetMyUnit()
        {
           return MyUnitList;
        }

    
    }
}
