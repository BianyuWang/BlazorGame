using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorGame.Shared.Models
{
    public class Wizard : Unit
    {


        public Wizard()
        {
            setHitpoint(70, 80);
            setDefense(1, 5);
            setAttacK(20, 25);         
            Title = UnitType.Wizard;
        }
       
    }
}
