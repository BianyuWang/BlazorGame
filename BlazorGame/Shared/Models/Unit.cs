using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorGame.Shared.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int HitPoint { get; set; }

        public int Cost { get; set; }

        public int Defense { get; set; }

        public int Attack { get; set; }

        public int ReturnPoint  =>(int)( Cost / 2);

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
