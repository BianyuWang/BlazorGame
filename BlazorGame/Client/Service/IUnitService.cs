﻿using BlazorGame.Shared.Models;

namespace BlazorGame.Client.Service
{
  public  interface  IUnitService
    {
       static  IList<Unit> UnitTypeList { get; set; }
        IList<Unit> MyUnitList { get; set; }

        void AddUnit(int unitId);

        void DeleteUnit(Unit unit);

        void Attack(Unit Attacker, Unit Defender);

        IList<Unit> GetUnitType();

        IList<Unit> GetMyUnit();

    }
}