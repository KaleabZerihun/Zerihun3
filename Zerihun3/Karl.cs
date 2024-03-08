/********************************************************************
*** NAME : Kaleab Zerihun
*** CLASS : CSc 346
*** ASSIGNMENT : Assignment 3
*** DUE DATE : 03-08-24
*** INSTRUCTOR : GAMRADT
*********************************************************************
*** DESCRIPTION : Karl class used to set and assign values
********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VikingNS
{
    public class Karl : Viking
    {
        // Automatic property
        public Global.Duty Duty { get; set; }

/********************************************************************
*** METHOD <Viking>
*********************************************************************
*** DESCRIPTION : Default constructor for Karl class
*** INPUT ARGS : N/A
*** OUTPUT ARGS : N/A
*** IN/OUT ARGS : N/A
*** RETURN : N/A
********************************************************************/
        public Karl() : base()
        {
            Duty = Global.Duty.FARMER;
        }
/********************************************************************
*** METHOD <Viking>
*********************************************************************
*** DESCRIPTION : Copy constructor for Karl class
*** INPUT ARGS : N/A
*** OUTPUT ARGS : N/A
*** IN/OUT ARGS : N/A
*** RETURN : N/A
********************************************************************/
        public Karl(Karl karl) : base(karl)
        {
            Duty = karl.Duty;
        }
/********************************************************************
*** METHOD <Viking>
*********************************************************************
*** DESCRIPTION : Parameterized Copy constructor for Karl class
*** INPUT ARGS : N/A
*** OUTPUT ARGS : N/A
*** IN/OUT ARGS : N/A
*** RETURN : N/A
********************************************************************/
        public Karl(string name,
         short health, 
         Global.Weapon weapon, 
         bool shield, Global.Duty duty = Global.Duty.FARMER) : base(name, health, Global.Weapon.NONE, false)
        {
            Duty = duty;
        }

        public override string ToString()
        {
            string forReturn = $"Duty:\t{Duty}\n";
            return forReturn;
        }

    }
}