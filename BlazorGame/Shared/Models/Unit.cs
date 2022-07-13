﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorGame.Shared.Models
{
    public enum UnitType
    { 
    Archer,
    Knight,
    Wizard
    }

    public class Unit
    {
        public int Id { get; set; }
        public UnitType Title { get; set; }
        public int HitPoint { get; set; }

        public int Cost { get; set; }

        public int Defense { get; set; }

        public int Attack { get; set; }

        public int RefoundCoin  =>(int)( Cost / 2);

        public void setHitpoint(int min, int max)
        {
            HitPoint = Random.Shared.Next(min, max);
        }
        public void setAttacK(int min, int max)
        {
            Attack = Random.Shared.Next(min, max);
        }


        public void setDefense(int min, int max)
        {
            Defense = Random.Shared.Next(min, max);
        }

        
    }
}
