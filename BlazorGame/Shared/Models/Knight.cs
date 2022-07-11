using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorGame.Shared.Models
{
    public class Knight : Unit
    {
      

        public Knight()
        {
            setHitpoint(100, 120);
            setDefense(10, 15);
            setAttacK(10, 15);
            Title  = "knight";
            Cost  = 100;
        }
    }
}
