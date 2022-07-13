using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorGame.Shared.Models
{
    public class Archer :Unit
    {
   

        public Archer()
        {
            setHitpoint(80, 100);
            setDefense(5, 10);
            setAttacK(15, 20);
            Title = UnitType.Archer;
            Cost  = 150;
    }
    }
}
